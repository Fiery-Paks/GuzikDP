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

namespace TravelAgencyGuzik.UserControls
{
    public partial class UserControlHotelsAdd: UserControlParent
    {
        public UserControlHotelsAdd()
        {
            InitializeComponent();
        }
        private Model1 model = new Model1();
        private void UserControlHotelsAdd_Load(object sender, EventArgs e)
        {
           citiesBindingSource.DataSource = model.Cities.ToList();
        }

        private void photoPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//класс который открывает окно для работы с файлами
            ofd.Title = "Выберите фото отеля";//задаём заголовок окна
            ofd.Filter = "Файлы JPG, PNG|*.jpg;*.png|Все файлы (*.*)|*.*";// задаём фильтр для отображаемых файлов
            if (ofd.ShowDialog() == DialogResult.OK)//если нажали OK
                pictureBox1.Image = Image.FromFile(ofd.FileName);//показываем выбранный файл в pictureBox1
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(addressTextBox.Text) && 
            !String.IsNullOrWhiteSpace(hotelNameTextBox.Text)&&
                !maskedTextBox1.MaskCompleted)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Не задан файл с фото!");
                return;
            }

                //  создаем новый объект класса Student
            Hotels hotel = new Hotels();

            byte[] bImg = (byte[])new ImageConverter().ConvertTo(pictureBox1.Image, typeof(byte[]));
            hotel.Photo = bImg;
            hotel.StarRating = trackBarStar.Value;
            hotel.Address = addressTextBox.Text;
            hotel.CityId = (int)cityIdComboBox.SelectedValue;
            hotel.PhoneNumber = maskedTextBox1.Text;
            try
            {//сохраняем данные
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var parentForm = this.FindForm() as FormMenu; // Получаем родительскую форму
            if (parentForm != null)
            {
                parentForm.LoadUserControl(new UserControlHotels()); // Загружаем новый UserControl
            }
        }
    }
}
