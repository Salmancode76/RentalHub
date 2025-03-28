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

namespace Project_AP.From.Admin.Controls
{
    public partial class Admin2_StoreEquipment : UserControl
    {
        public Admin2_StoreEquipment()
        {
            InitializeComponent();
        }

        private void Admin2_StoreEquipment_Load(object sender, EventArgs e)
        {

        }

        private void S_E_Update_Button_Click(object sender, EventArgs e)
        {

        }

        private void S_E_Delete_Button_Click(object sender, EventArgs e)
        {

        }

        private void S_E_AddNew_Button_Click(object sender, EventArgs e)
        {
            this.Parent.Hide();
            using (AddNewEquipmentFormPopup PopupForm = new AddNewEquipmentFormPopup())
            {
                PopupForm.ShowDialog();
            }
            this.Parent.Show();
        }
    }
}
