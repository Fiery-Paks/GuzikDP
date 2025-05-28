using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgencyGuzik.UserControls;

namespace TravelAgencyGuzik.Forms
{
    public partial class FormMenu: Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        public void LoadUserControl(UserControlParent userControl)
        {
            tableLayoutPanel1.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(userControl);
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlMenu());
        }
    }
}
