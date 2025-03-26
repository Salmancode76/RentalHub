using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_AP.From.Admin.Controls.Admin_Rentals
{
    public partial class Admin_Rentals : UserControl
    {
        public Admin_Rentals()
        {
            InitializeComponent();
        }

        private void ShowRentals_Click(String name)
        {

            if (name == "Requests")
            {
                rentals_Requests1.Visible = true;
                rentals_Tracking1.Visible = false;
                rentals_HistoryReport1.Visible = false;
            }
            else if (name == "RentalsTrack")
            {
                rentals_Requests1.Visible = false;
                rentals_Tracking1.Visible = true;
                rentals_HistoryReport1.Visible = false;
            }
            else if (name == "HistoryReport")
            {
                rentals_Requests1.Visible = false;
                rentals_Tracking1.Visible = false;
                rentals_HistoryReport1.Visible = true;
            }

        }


        private void R_Requests_Click(object sender, EventArgs e)
        {
            ShowRentals_Click("Requests");
        }

        private void R_RentalsTrack_Click(object sender, EventArgs e)
        {
            ShowRentals_Click("RentalsTrack");
        }

        private void R_HistoryReport_Click(object sender, EventArgs e)
        {
            ShowRentals_Click("HistoryReport");
        }

        private void Admin_Rentals_Load(object sender, EventArgs e)
        {
            ShowRentals_Click("Requests");
        }
    }
}
