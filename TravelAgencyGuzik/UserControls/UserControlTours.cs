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
using TravelAgencyGuzik.UserControlsTile;

namespace TravelAgencyGuzik.UserControls
{
    public partial class UserControlTours: UserControlParent
    {
        public UserControlTours()
        {
            InitializeComponent();
        }
        private Model1 model = new Model1();
        private void buttonBack_Click(object sender, EventArgs e)
        {
            var parentForm = this.FindForm() as FormMenu; // Получаем родительскую форму
            if (parentForm != null)
            {
                parentForm.LoadUserControl(new UserControlMenu()); // Загружаем новый UserControl
            }
        }

        private void UserControlTours_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Tours tour in model.Tours.Where(x=> x.TourName.Contains(textBoxSearch.Text)))
            {
                flowLayoutPanel1.Controls.Add(new UserControlTileTour(model, tour));
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var parentForm = this.FindForm() as FormMenu; // Получаем родительскую форму
            if (parentForm != null)
            {
                parentForm.LoadUserControl(new UserControlToursAddUpdate(model)); // Загружаем новый UserControl
            }
        }
    }
}
