using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgencyGuzik.ModelEF;
using TravelAgencyGuzik.Forms;
using System.IO;
using System.Xml.Linq;

namespace TravelAgencyGuzik.UserControls
{
    public partial class UserControlBookingsAddUpdate : UserControlParent
    {
        private Model1 model;
        private Bookings bookings;
        private bool IsAdd;
        public UserControlBookingsAddUpdate(Model1 _model)
        {
            InitializeComponent();
            this.model = _model;
            this.bookings = null;
            this.IsAdd = true;
            LoadData();
        }

        public UserControlBookingsAddUpdate(Model1 _model, Bookings _bookings)
        {
            InitializeComponent();
            this.model = _model;
            this.bookings = _bookings;
            this.IsAdd = false;
            LoadData();
        }

        private void UserControlBookingsAddUpdate_Load(object sender, EventArgs e)
        {
            if (IsAdd)
            {
                statusComboBox.SelectedIndex = 0;
                paymentStatusComboBox.SelectedIndex = 0;
                scannedDocLinkLabel.Text = "Скан не прикреплён";
            }
            else
            {
                labelName.Text = "Изменение данных бронирования ID " + bookings.Id;
                bookingsBindingSource.DataSource = bookings;
                if (this.bookings.ScannedDoc != null)
                    scannedDocLinkLabel.Text = "Скан прикреплён";
                else
                    scannedDocLinkLabel.Text = "Скан не прикреплён";
            }
        }

        private void LoadData()
        {
            clientsBindingSource.DataSource = model.Clients.ToList();
            staffBindingSource.DataSource = model.Staff.ToList();
            toursBindingSource.DataSource = model.Tours.ToList();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var parentForm = this.FindForm() as FormMenu;
            if (parentForm != null)
            {
                parentForm.LoadUserControl(new UserControlBookingsTable());
            }
        }

        private void scannedDocLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!IsAdd && bookings.ScannedDoc != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFileDialog.FileName = $"Dogovor_{DateTime.Now.ToString().Replace(":", "-")}.pdf";
                saveFileDialog.Title = "Сохранить файл PDF";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, bookings.ScannedDoc);
                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
            }
        }
        private void AttachPdfDocument()
        {
            OpenFileDialog ofd = new OpenFileDialog();//класс который открывает окно для работы с файлами
            ofd.Title = "Выберите скан договора в формате pdf";//задаём заголовок окна
            ofd.Filter = "Файлы PDF|*.pdf|Все файлы (*.*)|*.*";// задаём фильтр для отображаемых файлов
            if (ofd.ShowDialog() == DialogResult.OK)//если нажали OK
            {
                bookings.ScannedDoc = File.ReadAllBytes(ofd.FileName);
                scannedDocLinkLabel.Text = "Скан прикреплён";
                MessageBox.Show("Документ прикреплён");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(paymentAmountTextBox.Text, out decimal Amount))
            {
                MessageBox.Show("Поле Payment Amount должно содержать значение числа с плавающей запятой!");
                return;
            }

            if (IsAdd)
                bookings = new Bookings();

            bookings.ClientId = (int)clientIdComboBox.SelectedValue;
            bookings.StaffId = (int)staffIdComboBox.SelectedValue;
            bookings.TourId = (int)tourIdComboBox.SelectedValue;
            bookings.BookingDate = bookingDateDateTimePicker.Value;
            bookings.PaymentAmount = Amount;
            bookings.PaymentStatus = paymentStatusComboBox.SelectedItem.ToString();
            bookings.Status = statusComboBox.SelectedItem.ToString();


            if (bookings.ScannedDoc == null)
            {
                AttachPdfDocument();
            }
            else
            {
                DialogResult dr = MessageBox.Show(
                  "Вы хотите изменить скан договора бронирования - " + bookings.Id.ToString(),
                  "Измененения скана брони", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    AttachPdfDocument();
                }
            }

            if (IsAdd)
                model.Bookings.Add(bookings);

            try
            {
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Бронь сохранена!");
            var parentForm = this.FindForm() as FormMenu;
            if (parentForm != null)
            {
                parentForm.LoadUserControl(new UserControlBookingsTable());
            }
        }
    }
}
