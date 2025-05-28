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
using System.Drawing.Printing;

namespace TravelAgencyGuzik.UserControls
{
    public partial class UserControlBookingsTable : UserControlParent
    {
        public UserControlBookingsTable()
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var parentForm = this.FindForm() as FormMenu; // Получаем родительскую форму
            if (parentForm != null)
            {
                parentForm.LoadUserControl(new UserControlBookingsAddUpdate(model)); // Загружаем новый UserControl
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Bookings bookings = (Bookings)bookingsBindingSource.Current;
            var parentForm = this.FindForm() as FormMenu; // Получаем родительскую форму
            if (parentForm != null)
            {
                parentForm.LoadUserControl(new UserControlBookingsAddUpdate(model, bookings)); // Загружаем новый UserControl
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Bookings bookings = (Bookings)bookingsBindingSource.Current;
            DialogResult dr = MessageBox.Show(
                "Вы действительно хотите удалить бронирование - " + bookings.Id.ToString(),
                "Удаление брони", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                model.Bookings.Remove(bookings);
                try
                {
                    model.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                bookingsBindingSource.DataSource = model.Bookings.ToList();
            }
        }

        private void UserControlBookings_Load(object sender, EventArgs e)
        {
            bookingsBindingSource.DataSource = model.Bookings.ToList();
        }
    }
}
