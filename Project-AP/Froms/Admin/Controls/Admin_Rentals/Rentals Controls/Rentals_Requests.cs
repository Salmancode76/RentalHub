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
    public partial class Rentals_Requests : UserControl
    {
        public Rentals_Requests()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void S_Rs_AnaliseRquest_Button_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Hide(); 
            using (AnaliseRentalRequestFormPopup PopupForm = new AnaliseRentalRequestFormPopup())
            {
                PopupForm.ShowDialog();
            }
            this.Parent.Parent.Show();
        }
    }
}
