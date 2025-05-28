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

namespace TravelAgencyGuzik.UserControls
{
    public partial class UserControlHotels : UserControlParent
    {
        public UserControlHotels()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var parentForm = this.FindForm() as FormMenu; // Получаем родительскую форму
            if (parentForm != null)
            {
                parentForm.LoadUserControl(new UserControlMenu()); // Загружаем новый UserControl
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var parentForm = this.FindForm() as FormMenu; // Получаем родительскую форму
            if (parentForm != null)
            {
                parentForm.LoadUserControl(new UserControlHotelsAdd()); // Загружаем новый UserControl
            }
        }

        private void UserControlHotels_Load(object sender, EventArgs e)
        {
            Model1 model1 = new Model1();
            hotelsBindingSource.DataSource = model1.Hotels.ToList();
        }
    }
}
