namespace Project_AP.From.Admin.Controls
{
    partial class AdminCore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            Core_Accounts_Button = new Button();
            Core_StoreEquipent_Button = new Button();
            Core_Rentals_Button = new Button();
            Core_Dashboard_Button = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            admin_Dashboard1 = new Admin_Dashboard();
            admin_Accounts1 = new Admin_Accounts();
            admin2_StoreEquipment1 = new Admin2_StoreEquipment();
            admin_Rentals1 = new Project_AP.From.Admin.Controls.Admin_Rentals.Admin_Rentals();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(Core_Accounts_Button);
            panel1.Controls.Add(Core_StoreEquipent_Button);
            panel1.Controls.Add(Core_Rentals_Button);
            panel1.Controls.Add(Core_Dashboard_Button);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 670);
            panel1.TabIndex = 0;
            // 
            // Core_Accounts_Button
            // 
            Core_Accounts_Button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Core_Accounts_Button.Location = new Point(12, 463);
            Core_Accounts_Button.Name = "Core_Accounts_Button";
            Core_Accounts_Button.Size = new Size(234, 81);
            Core_Accounts_Button.TabIndex = 4;
            Core_Accounts_Button.Text = "Accounts";
            Core_Accounts_Button.UseVisualStyleBackColor = true;
            Core_Accounts_Button.Click += Core_Accounts_Button_Click;
            // 
            // Core_StoreEquipent_Button
            // 
            Core_StoreEquipent_Button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Core_StoreEquipent_Button.Location = new Point(12, 365);
            Core_StoreEquipent_Button.Name = "Core_StoreEquipent_Button";
            Core_StoreEquipent_Button.Size = new Size(234, 81);
            Core_StoreEquipent_Button.TabIndex = 3;
            Core_StoreEquipent_Button.Text = "Store Equipment";
            Core_StoreEquipent_Button.UseVisualStyleBackColor = true;
            Core_StoreEquipent_Button.Click += Core_StoreEquipent_Button_Click;
            // 
            // Core_Rentals_Button
            // 
            Core_Rentals_Button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Core_Rentals_Button.Location = new Point(12, 267);
            Core_Rentals_Button.Name = "Core_Rentals_Button";
            Core_Rentals_Button.Size = new Size(234, 81);
            Core_Rentals_Button.TabIndex = 2;
            Core_Rentals_Button.Text = "Rentals";
            Core_Rentals_Button.UseVisualStyleBackColor = true;
            Core_Rentals_Button.Click += Core_Rentals_Button_Click;
            // 
            // Core_Dashboard_Button
            // 
            Core_Dashboard_Button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Core_Dashboard_Button.Location = new Point(12, 171);
            Core_Dashboard_Button.Name = "Core_Dashboard_Button";
            Core_Dashboard_Button.Size = new Size(234, 81);
            Core_Dashboard_Button.TabIndex = 1;
            Core_Dashboard_Button.Text = "Dashboard";
            Core_Dashboard_Button.UseVisualStyleBackColor = true;
            Core_Dashboard_Button.Click += Core_Dashboard_Button_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(28, 28, 43);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 150);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PMingLiU-ExtB", 34F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(228, 68);
            label2.TabIndex = 1;
            label2.Text = "Rentals";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 34F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(245, 68);
            label1.TabIndex = 0;
            label1.Text = "Ahmnio";
            // 
            // admin_Dashboard1
            // 
            admin_Dashboard1.BackColor = SystemColors.ActiveCaption;
            admin_Dashboard1.Location = new Point(260, -2);
            admin_Dashboard1.Name = "admin_Dashboard1";
            admin_Dashboard1.Size = new Size(1001, 670);
            admin_Dashboard1.TabIndex = 1;
            // 
            // admin_Accounts1
            // 
            admin_Accounts1.BackColor = Color.HotPink;
            admin_Accounts1.Location = new Point(260, 1);
            admin_Accounts1.Name = "admin_Accounts1";
            admin_Accounts1.Size = new Size(1001, 667);
            admin_Accounts1.TabIndex = 2;
            // 
            // admin2_StoreEquipment1
            // 
            admin2_StoreEquipment1.Location = new Point(260, 1);
            admin2_StoreEquipment1.Name = "admin2_StoreEquipment1";
            admin2_StoreEquipment1.Size = new Size(1001, 670);
            admin2_StoreEquipment1.TabIndex = 3;
            // 
            // admin_Rentals1
            // 
            admin_Rentals1.Location = new Point(260, 1);
            admin_Rentals1.Name = "admin_Rentals1";
            admin_Rentals1.Size = new Size(1001, 670);
            admin_Rentals1.TabIndex = 4;
            // 
            // AdminCore
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(admin_Rentals1);
            Controls.Add(admin2_StoreEquipment1);
            Controls.Add(admin_Accounts1);
            Controls.Add(admin_Dashboard1);
            Controls.Add(panel1);
            Name = "AdminCore";
            Text = "AdminCore";
            Load += AdminCore_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Core_Accounts_Button;
        private Button Core_StoreEquipent_Button;
        private Button Core_Rentals_Button;
        private Button Core_Dashboard_Button;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Admin_Dashboard admin_Dashboard1;
        private Admin_Accounts admin_Accounts1;
        private Admin2_StoreEquipment admin2_StoreEquipment1;
        private Admin_Rentals.Admin_Rentals admin_Rentals1;
    }
}