using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgencyGuzik.Forms;
using TravelAgencyGuzik.ModelEF;
using System.Data.Entity.Core.Metadata.Edm;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;

namespace TravelAgencyGuzik.UserControls
{
    public partial class UserControlToursAddUpdate : UserControlParent
    {
        private Model1 model;
        private Tours tours;
        private bool IsAdd;
        public UserControlToursAddUpdate(Model1 model_)
        {
            InitializeComponent();
            this.model = model_;
            IsAdd = true;
        }
        public UserControlToursAddUpdate(Model1 model_, Tours tours_)
        {
            InitializeComponent();
            this.model = model_;
            this.tours = tours_;
            IsAdd = false;
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            var parentForm = this.FindForm() as FormMenu;
            if (parentForm != null)
            {
                parentForm.LoadUserControl(new UserControlTours());
            }
        }

        private void UserControlToursAddUpdate_Load(object sender, EventArgs e)
        {
            hotelsBindingSource.DataSource = model.Hotels.ToList();
            if (!IsAdd)
            {
                toursBindingSource.DataSource = tours;
            }
            if (!IsAdd && tours.Photo != null)
            {
                using (var ms = new MemoryStream(tours.Photo))
                {
                    var image = Image.FromStream(ms);
                    if (photoPictureBox.Image != null)
                        photoPictureBox.Image.Dispose();
                    photoPictureBox.Image = image;
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tourNameTextBox.Text))
            {
                MessageBox.Show("Имя тура должно быть заполнено!");
                return;
            }
            if (!decimal.TryParse(priceTextBox.Text, out decimal Price))
            {
                MessageBox.Show("Поле Price должно содержать значение числа с плавающей запятой!");
                return;
            }
            if (endDateDateTimePicker.Value <= startDateDateTimePicker.Value)
            {
                MessageBox.Show("Дата начала должна быть меньше даты конца!");
                return;
            }

            if (IsAdd)
                tours = new Tours();

            byte[] bImg = (byte[])new ImageConverter().ConvertTo(photoPictureBox.Image, typeof(byte[]));
            tours.Photo = bImg;
            tours.TourName = tourNameTextBox.Text;
            tours.HotelId = (int)hotelIdComboBox.SelectedValue;
            tours.StartDate = startDateDateTimePicker.Value;
            tours.EndDate = endDateDateTimePicker.Value;
            tours.Price = Price;
            tours.AvailablePlaces = (int)availablePlacesNumericUpDown.Value;
            tours.Description = descriptionTextBox.Text;

            if (IsAdd)
                model.Tours.Add(tours);

            try
            {
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Тур сохранён!");
            var parentForm = this.FindForm() as FormMenu;
            if (parentForm != null)
            {
                parentForm.LoadUserControl(new UserControlTours());
            }
        }

        private void photoPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//класс который открывает окно для работы с файлами
            ofd.Title = "Выберите фото отеля";//задаём заголовок окна
            ofd.Filter = "Файлы JPG, PNG|*.jpg;*.png|Все файлы (*.*)|*.*";// задаём фильтр для отображаемых файлов
            if (ofd.ShowDialog() == DialogResult.OK)//если нажали OK
                photoPictureBox.Image = Image.FromFile(ofd.FileName);//показываем выбранный файл в pictureBox1
        }
    }
}
