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

namespace TravelAgencyGuzik.UserControls
{
    public partial class UserControlMenu: UserControlParent
    {
        public UserControlMenu()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Visible = true;
            FindForm().Close();
        }

        private void buttonShowHotels_Click(object sender, EventArgs e)
        {
            var parentForm = this.FindForm() as FormMenu; // Получаем родительскую форму
            if (parentForm != null)
            {
                parentForm.LoadUserControl(new UserControlHotels()); // Загружаем новый UserControl
            }
        }

        private void buttonBookings_Click(object sender, EventArgs e)
        {

        }
    }
}
