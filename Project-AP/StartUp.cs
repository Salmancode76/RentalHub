using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_AP.From.Admin;
using Project_AP.From.Admin.Controls;

namespace Project_AP
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void StartUp_Load(object sender, EventArgs e)
        {

        }

        private void LogIn_Button_Click(object sender, EventArgs e)
        {
            // Add authantication logic here

            // If authantication is successful
            this.Hide();
            new AdminCore().Show();
            //or
            //new Emp_Core().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
