using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgencyGuzik.ModelEF;

namespace TravelAgencyGuzik.Forms
{
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }
        public static Staff EnterUser;
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            EnterUser = null;
            Model1 model1 = new Model1();
            //поиск пользователя по логину и паролю
            EnterUser = model1.Staff.FirstOrDefault(x => x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);
            if (EnterUser != null)
            {
                FormMenu formMenu = new FormMenu();
                formMenu.Show();
                Hide();
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            textBoxLogin.Text = "vasileva";
            textBoxPassword.Text = "pass123";
        }
    }
}
