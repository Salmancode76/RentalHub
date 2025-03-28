namespace Project_AP.From.Admin.Controls.Rentals_Controls
{
    partial class Rentals_Requests
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
            RentalsRequests_GridTable = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            S_Rs_AnaliseRquest_Button = new Button();
            panel1 = new Panel();
            label7 = new Label();
            S_Rs_EquipmentName_TextFiled = new TextBox();
            S_Rs_UserName_TextFiled = new TextBox();
            S_Rs_UserID_TextFiled = new TextBox();
            S_Rs_RentalID_TextFiled = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SearchBar_TextFiled = new TextBox();
            label1 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)RentalsRequests_GridTable).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // RentalsRequests_GridTable
            // 
            RentalsRequests_GridTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RentalsRequests_GridTable.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            RentalsRequests_GridTable.Location = new Point(22, 43);
            RentalsRequests_GridTable.Name = "RentalsRequests_GridTable";
            RentalsRequests_GridTable.RowHeadersWidth = 62;
            RentalsRequests_GridTable.RowTemplate.Height = 33;
            RentalsRequests_GridTable.Size = new Size(742, 546);
            RentalsRequests_GridTable.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "add here guys what you wants i depands on you";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 400;
            // 
            // S_Rs_AnaliseRquest_Button
            // 
            S_Rs_AnaliseRquest_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            S_Rs_AnaliseRquest_Button.Location = new Point(783, 519);
            S_Rs_AnaliseRquest_Button.Name = "S_Rs_AnaliseRquest_Button";
            S_Rs_AnaliseRquest_Button.Size = new Size(193, 70);
            S_Rs_AnaliseRquest_Button.TabIndex = 1;
            S_Rs_AnaliseRquest_Button.Text = "Analise Rquest";
            S_Rs_AnaliseRquest_Button.UseVisualStyleBackColor = true;
            S_Rs_AnaliseRquest_Button.Click += S_Rs_AnaliseRquest_Button_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(S_Rs_EquipmentName_TextFiled);
            panel1.Controls.Add(S_Rs_UserName_TextFiled);
            panel1.Controls.Add(S_Rs_UserID_TextFiled);
            panel1.Controls.Add(S_Rs_RentalID_TextFiled);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(783, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 458);
            panel1.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 394);
            label7.Name = "label7";
            label7.Size = new Size(149, 25);
            label7.TabIndex = 8;
            label7.Text = "If want add more";
            // 
            // S_Rs_EquipmentName_TextFiled
            // 
            S_Rs_EquipmentName_TextFiled.Location = new Point(17, 285);
            S_Rs_EquipmentName_TextFiled.Name = "S_Rs_EquipmentName_TextFiled";
            S_Rs_EquipmentName_TextFiled.Size = new Size(164, 31);
            S_Rs_EquipmentName_TextFiled.TabIndex = 7;
            // 
            // S_Rs_UserName_TextFiled
            // 
            S_Rs_UserName_TextFiled.Location = new Point(17, 211);
            S_Rs_UserName_TextFiled.Name = "S_Rs_UserName_TextFiled";
            S_Rs_UserName_TextFiled.Size = new Size(164, 31);
            S_Rs_UserName_TextFiled.TabIndex = 6;
            // 
            // S_Rs_UserID_TextFiled
            // 
            S_Rs_UserID_TextFiled.Location = new Point(13, 133);
            S_Rs_UserID_TextFiled.Name = "S_Rs_UserID_TextFiled";
            S_Rs_UserID_TextFiled.Size = new Size(164, 31);
            S_Rs_UserID_TextFiled.TabIndex = 5;
            // 
            // S_Rs_RentalID_TextFiled
            // 
            S_Rs_RentalID_TextFiled.Location = new Point(17, 54);
            S_Rs_RentalID_TextFiled.Name = "S_Rs_RentalID_TextFiled";
            S_Rs_RentalID_TextFiled.Size = new Size(164, 31);
            S_Rs_RentalID_TextFiled.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 257);
            label5.Name = "label5";
            label5.Size = new Size(154, 25);
            label5.TabIndex = 3;
            label5.Text = "Equipment Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 105);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 2;
            label4.Text = "User ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 183);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 1;
            label3.Text = "User Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 26);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 0;
            label2.Text = "Rental ID:";
            // 
            // SearchBar_TextFiled
            // 
            SearchBar_TextFiled.BackColor = Color.Gainsboro;
            SearchBar_TextFiled.BorderStyle = BorderStyle.FixedSingle;
            SearchBar_TextFiled.Location = new Point(221, 9);
            SearchBar_TextFiled.Multiline = true;
            SearchBar_TextFiled.Name = "SearchBar_TextFiled";
            SearchBar_TextFiled.PlaceholderText = "Search By: if you want guys add or remove";
            SearchBar_TextFiled.Size = new Size(345, 28);
            SearchBar_TextFiled.TabIndex = 16;
            SearchBar_TextFiled.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(22, 10);
            label1.Name = "label1";
            label1.Size = new Size(193, 28);
            label1.TabIndex = 15;
            label1.Text = "Rental Requsts:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("PMingLiU-ExtB", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(796, 34);
            label6.Name = "label6";
            label6.Size = new Size(161, 22);
            label6.TabIndex = 17;
            label6.Text = "Selected Rental:";
            // 
            // Rentals_Requests
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(label6);
            Controls.Add(SearchBar_TextFiled);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(S_Rs_AnaliseRquest_Button);
            Controls.Add(RentalsRequests_GridTable);
            Name = "Rentals_Requests";
            Size = new Size(1001, 604);
            ((System.ComponentModel.ISupportInitialize)RentalsRequests_GridTable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView RentalsRequests_GridTable;
        private Button S_Rs_AnaliseRquest_Button;
        private Panel panel1;
        private TextBox SearchBar_TextFiled;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox S_Rs_EquipmentName_TextFiled;
        private TextBox S_Rs_UserName_TextFiled;
        private TextBox S_Rs_UserID_TextFiled;
        private TextBox S_Rs_RentalID_TextFiled;
        private DataGridViewTextBoxColumn Column1;
        private Label label1;
        private Label label7;
        private Label label6;
    }
}
