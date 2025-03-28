using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_AP.Froms.Admin.Admin_popup_forms;

namespace Project_AP.From.Admin.Controls.Rentals_Controls
{
    public partial class Rentals_Tracking : UserControl
    {
        public Rentals_Tracking()
        {
            InitializeComponent();
        }

        private void S_Rs_UserID_TextFiled_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManageRental_Button_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Hide();
            using (ManageRentalFormPopup PopupForm = new ManageRentalFormPopup())
            {
                PopupForm.ShowDialog();
            }
            this.Parent.Parent.Show();
        }
    }
}
