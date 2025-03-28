namespace Project_AP.From.Admin.Controls.Rentals_Controls
{
    partial class Rentals_Tracking
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            SearchBar_TextFiled = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            S_AR_RentalStatus_TextFiled = new TextBox();
            label5 = new Label();
            S_AR_Equipment_TextFiled = new TextBox();
            S_AR_UserName_TextFiled = new TextBox();
            S_AR_RentalID_TextFiled = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            ManageRental_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(945, 431);
            dataGridView1.TabIndex = 0;
            // 
            // SearchBar_TextFiled
            // 
            SearchBar_TextFiled.BackColor = Color.Gainsboro;
            SearchBar_TextFiled.BorderStyle = BorderStyle.FixedSingle;
            SearchBar_TextFiled.Location = new Point(185, 21);
            SearchBar_TextFiled.Multiline = true;
            SearchBar_TextFiled.Name = "SearchBar_TextFiled";
            SearchBar_TextFiled.PlaceholderText = "Search By: Depende on you";
            SearchBar_TextFiled.Size = new Size(232, 28);
            SearchBar_TextFiled.TabIndex = 18;
            SearchBar_TextFiled.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(29, 21);
            label1.Name = "label1";
            label1.Size = new Size(150, 28);
            label1.TabIndex = 17;
            label1.Text = "All Rentals:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "Confomed", "Approved", "Rejected", "ext.." });
            listBox1.Location = new Point(537, 21);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(228, 29);
            listBox1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PMingLiU-ExtB", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(453, 25);
            label2.Name = "label2";
            label2.Size = new Size(78, 24);
            label2.TabIndex = 20;
            label2.Text = "Status:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("PMingLiU-ExtB", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(42, 486);
            label6.Name = "label6";
            label6.Size = new Size(161, 22);
            label6.TabIndex = 22;
            label6.Text = "Selected Rental:";
            // 
            // panel1
            // 
            panel1.Controls.Add(S_AR_RentalStatus_TextFiled);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(S_AR_Equipment_TextFiled);
            panel1.Controls.Add(S_AR_UserName_TextFiled);
            panel1.Controls.Add(S_AR_RentalID_TextFiled);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(29, 501);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 85);
            panel1.TabIndex = 21;
            // 
            // S_AR_RentalStatus_TextFiled
            // 
            S_AR_RentalStatus_TextFiled.Location = new Point(545, 42);
            S_AR_RentalStatus_TextFiled.Name = "S_AR_RentalStatus_TextFiled";
            S_AR_RentalStatus_TextFiled.Size = new Size(164, 31);
            S_AR_RentalStatus_TextFiled.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(366, 14);
            label5.Name = "label5";
            label5.Size = new Size(154, 25);
            label5.TabIndex = 7;
            label5.Text = "Equipemnt Name:";
            // 
            // S_AR_Equipment_TextFiled
            // 
            S_AR_Equipment_TextFiled.Location = new Point(366, 42);
            S_AR_Equipment_TextFiled.Name = "S_AR_Equipment_TextFiled";
            S_AR_Equipment_TextFiled.Size = new Size(164, 31);
            S_AR_Equipment_TextFiled.TabIndex = 6;
            // 
            // S_AR_UserName_TextFiled
            // 
            S_AR_UserName_TextFiled.Location = new Point(191, 42);
            S_AR_UserName_TextFiled.Name = "S_AR_UserName_TextFiled";
            S_AR_UserName_TextFiled.Size = new Size(164, 31);
            S_AR_UserName_TextFiled.TabIndex = 5;
            S_AR_UserName_TextFiled.TextChanged += S_Rs_UserID_TextFiled_TextChanged;
            // 
            // S_AR_RentalID_TextFiled
            // 
            S_AR_RentalID_TextFiled.Location = new Point(17, 42);
            S_AR_RentalID_TextFiled.Name = "S_AR_RentalID_TextFiled";
            S_AR_RentalID_TextFiled.Size = new Size(164, 31);
            S_AR_RentalID_TextFiled.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(545, 14);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 2;
            label4.Text = "Rental Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 14);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 1;
            label3.Text = "User Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 14);
            label8.Name = "label8";
            label8.Size = new Size(87, 25);
            label8.TabIndex = 0;
            label8.Text = "Rental ID:";
            // 
            // ManageRental_Button
            // 
            ManageRental_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ManageRental_Button.Location = new Point(785, 501);
            ManageRental_Button.Name = "ManageRental_Button";
            ManageRental_Button.Size = new Size(189, 85);
            ManageRental_Button.TabIndex = 23;
            ManageRental_Button.Text = "Manage Rental";
            ManageRental_Button.UseVisualStyleBackColor = true;
            ManageRental_Button.Click += ManageRental_Button_Click;
            // 
            // Rentals_Tracking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(ManageRental_Button);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(SearchBar_TextFiled);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Rentals_Tracking";
            Size = new Size(1001, 607);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox SearchBar_TextFiled;
        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private Label label6;
        private Panel panel1;
        private TextBox S_AR_Equipment_TextFiled;
        private TextBox S_AR_UserName_TextFiled;
        private TextBox S_AR_RentalID_TextFiled;
        private Label label4;
        private Label label3;
        private Label label8;
        private TextBox S_AR_RentalStatus_TextFiled;
        private Label label5;
        private Button ManageRental_Button;
    }
}
