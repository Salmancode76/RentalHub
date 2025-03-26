using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_AP.From.Admin.Controls
{
    public partial class AdminCore : Form
    {
        public AdminCore()
        {
            InitializeComponent();
        }

        private void ShowPage(String name)
        {
            if (name == "Dashboard")
            {
                admin_Dashboard1.Visible = true;
                admin_Accounts1.Visible = false;
                admin2_StoreEquipment1.Visible = false;
                admin_Rentals1.Visible = false;

            }
            else if (name == "Rentals")
            {
                admin_Dashboard1.Visible = false;
                admin_Accounts1.Visible = false;
                admin2_StoreEquipment1.Visible = false;
                admin_Rentals1.Visible = true;
            }
            else if (name == "StoreEquipment")
            {
                admin_Dashboard1.Visible = false;
                admin_Accounts1.Visible = false;
                admin2_StoreEquipment1.Visible = true;
                admin_Rentals1.Visible = false;
            }
            else if (name == "Accounts")
            {
                admin_Dashboard1.Visible = false;
                admin_Accounts1.Visible = true;
                admin2_StoreEquipment1.Visible = false;
                admin_Rentals1.Visible = false;
            }
        }

        private void Core_Dashboard_Button_Click(object sender, EventArgs e)
        {
            ShowPage("Dashboard");
        }

        private void Core_Rentals_Button_Click(object sender, EventArgs e)
        {
            ShowPage("Rentals");
        }

        private void Core_StoreEquipent_Button_Click(object sender, EventArgs e)
        {
            ShowPage("StoreEquipment");

        }

        private void Core_Accounts_Button_Click(object sender, EventArgs e)
        {
            ShowPage("Accounts");
        }

        private void AdminCore_Load(object sender, EventArgs e)
        {
            ShowPage("Dashboard");
        }
    }
}
