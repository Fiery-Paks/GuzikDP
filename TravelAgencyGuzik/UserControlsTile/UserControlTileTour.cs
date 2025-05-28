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
using System.IO;
using TravelAgencyGuzik.Forms;
using TravelAgencyGuzik.UserControls;

namespace TravelAgencyGuzik.UserControlsTile
{
    public partial class UserControlTileTour : UserControl
    {
        private Tours tours;
        private Model1 model;
        public UserControlTileTour(Model1 model_, Tours tours_)
        {
            InitializeComponent();
            model = model_;
            tours = tours_;
        }

        private void UserControlTileTour_Load(object sender, EventArgs e)
        {
            toursBindingSource.DataSource = tours;
            if (tours.Photo != null)
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
        private void Controls_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult dr = MessageBox.Show(
                    $"Вы действительно хотите удалить тур -  {tours.Id}?",
                    "Удаление тура", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    model.Tours.Remove(tours);
                    try
                    {
                        model.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    this.Dispose();
                }
            }
        }

        private void Controls_DoubleClick(object sender, EventArgs e)
        {
            var parentForm = this.FindForm() as FormMenu; // Получаем родительскую форму
            if (parentForm != null)
            {
                parentForm.LoadUserControl(new UserControlToursAddUpdate(model, tours)); // Загружаем новый UserControl
            }
        }
    }
}
