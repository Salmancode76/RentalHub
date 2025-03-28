namespace Project_AP.From.Admin.Controls
{
    partial class Admin2_StoreEquipment
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
            E_AddNew_Button = new Button();
            S_E_Update_Button = new Button();
            label2 = new Label();
            S_E_Delete_Button = new Button();
            label1 = new Label();
            Store_E_GridTabel = new DataGridView();
            E_ID = new DataGridViewTextBoxColumn();
            E_Name = new DataGridViewTextBoxColumn();
            E_RentalPrice = new DataGridViewTextBoxColumn();
            E_Quantity = new DataGridViewTextBoxColumn();
            SearchBar_TextFiled = new TextBox();
            S_E_EquipmentName_TextFiled = new TextBox();
            S_E_Price_TextFiled = new TextBox();
            S_E_Status_TextFiled = new TextBox();
            S_E_Description_RichTextFiled = new RichTextBox();
            S_E_Condition_TextFiled = new TextBox();
            S_E_Penality_TextFiled = new TextBox();
            S_E_Quantity_TextFiled = new TextBox();
            S_E_ID = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel1 = new Panel();
            S_E_Category_ListBox = new ListBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)Store_E_GridTabel).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // E_AddNew_Button
            // 
            E_AddNew_Button.Location = new Point(815, 599);
            E_AddNew_Button.Name = "E_AddNew_Button";
            E_AddNew_Button.Size = new Size(153, 56);
            E_AddNew_Button.TabIndex = 13;
            E_AddNew_Button.Text = "Add New";
            E_AddNew_Button.UseVisualStyleBackColor = true;
            E_AddNew_Button.Click += S_E_AddNew_Button_Click;
            // 
            // S_E_Update_Button
            // 
            S_E_Update_Button.Location = new Point(480, 598);
            S_E_Update_Button.Name = "S_E_Update_Button";
            S_E_Update_Button.Size = new Size(148, 56);
            S_E_Update_Button.TabIndex = 11;
            S_E_Update_Button.Text = "Update";
            S_E_Update_Button.UseVisualStyleBackColor = true;
            S_E_Update_Button.Click += S_E_Update_Button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(480, 29);
            label2.Name = "label2";
            label2.Size = new Size(338, 28);
            label2.TabIndex = 10;
            label2.Text = "Selected Equipment Details:";
            // 
            // S_E_Delete_Button
            // 
            S_E_Delete_Button.Location = new Point(643, 598);
            S_E_Delete_Button.Name = "S_E_Delete_Button";
            S_E_Delete_Button.Size = new Size(154, 57);
            S_E_Delete_Button.TabIndex = 12;
            S_E_Delete_Button.Text = "Delete";
            S_E_Delete_Button.UseVisualStyleBackColor = true;
            S_E_Delete_Button.Click += S_E_Delete_Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(24, 16);
            label1.Name = "label1";
            label1.Size = new Size(212, 28);
            label1.TabIndex = 9;
            label1.Text = "Store Equipment:";
            // 
            // Store_E_GridTabel
            // 
            Store_E_GridTabel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Store_E_GridTabel.Columns.AddRange(new DataGridViewColumn[] { E_ID, E_Name, E_RentalPrice, E_Quantity });
            Store_E_GridTabel.Location = new Point(22, 47);
            Store_E_GridTabel.Name = "Store_E_GridTabel";
            Store_E_GridTabel.RowHeadersWidth = 62;
            Store_E_GridTabel.RowTemplate.Height = 33;
            Store_E_GridTabel.Size = new Size(428, 608);
            Store_E_GridTabel.TabIndex = 7;
            // 
            // E_ID
            // 
            E_ID.HeaderText = "ID";
            E_ID.MinimumWidth = 8;
            E_ID.Name = "E_ID";
            E_ID.Width = 45;
            // 
            // E_Name
            // 
            E_Name.HeaderText = "Name";
            E_Name.MinimumWidth = 8;
            E_Name.Name = "E_Name";
            E_Name.Width = 150;
            // 
            // E_RentalPrice
            // 
            E_RentalPrice.HeaderText = "Price";
            E_RentalPrice.MinimumWidth = 8;
            E_RentalPrice.Name = "E_RentalPrice";
            E_RentalPrice.Width = 80;
            // 
            // E_Quantity
            // 
            E_Quantity.HeaderText = "Quantity";
            E_Quantity.MinimumWidth = 8;
            E_Quantity.Name = "E_Quantity";
            E_Quantity.Width = 90;
            // 
            // SearchBar_TextFiled
            // 
            SearchBar_TextFiled.BackColor = Color.Gainsboro;
            SearchBar_TextFiled.BorderStyle = BorderStyle.FixedSingle;
            SearchBar_TextFiled.Location = new Point(242, 15);
            SearchBar_TextFiled.Multiline = true;
            SearchBar_TextFiled.Name = "SearchBar_TextFiled";
            SearchBar_TextFiled.PlaceholderText = "        Search By Name";
            SearchBar_TextFiled.Size = new Size(208, 28);
            SearchBar_TextFiled.TabIndex = 14;
            SearchBar_TextFiled.Tag = "";
            // 
            // S_E_EquipmentName_TextFiled
            // 
            S_E_EquipmentName_TextFiled.Enabled = false;
            S_E_EquipmentName_TextFiled.Location = new Point(27, 115);
            S_E_EquipmentName_TextFiled.Name = "S_E_EquipmentName_TextFiled";
            S_E_EquipmentName_TextFiled.Size = new Size(222, 31);
            S_E_EquipmentName_TextFiled.TabIndex = 0;
            // 
            // S_E_Price_TextFiled
            // 
            S_E_Price_TextFiled.Enabled = false;
            S_E_Price_TextFiled.Location = new Point(264, 115);
            S_E_Price_TextFiled.Name = "S_E_Price_TextFiled";
            S_E_Price_TextFiled.Size = new Size(222, 31);
            S_E_Price_TextFiled.TabIndex = 1;
            // 
            // S_E_Status_TextFiled
            // 
            S_E_Status_TextFiled.Enabled = false;
            S_E_Status_TextFiled.Location = new Point(27, 176);
            S_E_Status_TextFiled.Name = "S_E_Status_TextFiled";
            S_E_Status_TextFiled.Size = new Size(222, 31);
            S_E_Status_TextFiled.TabIndex = 2;
            // 
            // S_E_Description_RichTextFiled
            // 
            S_E_Description_RichTextFiled.Enabled = false;
            S_E_Description_RichTextFiled.Location = new Point(70, 387);
            S_E_Description_RichTextFiled.Name = "S_E_Description_RichTextFiled";
            S_E_Description_RichTextFiled.Size = new Size(380, 97);
            S_E_Description_RichTextFiled.TabIndex = 4;
            S_E_Description_RichTextFiled.Text = "";
            // 
            // S_E_Condition_TextFiled
            // 
            S_E_Condition_TextFiled.Enabled = false;
            S_E_Condition_TextFiled.Location = new Point(27, 247);
            S_E_Condition_TextFiled.Name = "S_E_Condition_TextFiled";
            S_E_Condition_TextFiled.Size = new Size(222, 31);
            S_E_Condition_TextFiled.TabIndex = 5;
            // 
            // S_E_Penality_TextFiled
            // 
            S_E_Penality_TextFiled.Enabled = false;
            S_E_Penality_TextFiled.Location = new Point(264, 247);
            S_E_Penality_TextFiled.Name = "S_E_Penality_TextFiled";
            S_E_Penality_TextFiled.Size = new Size(222, 31);
            S_E_Penality_TextFiled.TabIndex = 6;
            // 
            // S_E_Quantity_TextFiled
            // 
            S_E_Quantity_TextFiled.Enabled = false;
            S_E_Quantity_TextFiled.Location = new Point(151, 315);
            S_E_Quantity_TextFiled.Name = "S_E_Quantity_TextFiled";
            S_E_Quantity_TextFiled.Size = new Size(222, 31);
            S_E_Quantity_TextFiled.TabIndex = 8;
            // 
            // S_E_ID
            // 
            S_E_ID.AutoSize = true;
            S_E_ID.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            S_E_ID.Location = new Point(31, 35);
            S_E_ID.Name = "S_E_ID";
            S_E_ID.Size = new Size(187, 32);
            S_E_ID.TabIndex = 9;
            S_E_ID.Text = "Equipment ID: **";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(25, 87);
            label3.Name = "label3";
            label3.Size = new Size(153, 25);
            label3.TabIndex = 9;
            label3.Text = "Equipment Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(264, 87);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 10;
            label4.Text = "Rental Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(25, 149);
            label5.Name = "label5";
            label5.Size = new Size(159, 25);
            label5.TabIndex = 11;
            label5.Text = "Availability Status:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(262, 149);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 12;
            label6.Text = "Category:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(27, 219);
            label7.Name = "label7";
            label7.Size = new Size(94, 25);
            label7.TabIndex = 13;
            label7.Text = "Condition:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(264, 219);
            label8.Name = "label8";
            label8.Size = new Size(118, 25);
            label8.TabIndex = 14;
            label8.Text = "Late Penality:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(158, 292);
            label9.Name = "label9";
            label9.Size = new Size(155, 25);
            label9.TabIndex = 15;
            label9.Text = "Avalible Quantity:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(70, 361);
            label10.Name = "label10";
            label10.Size = new Size(105, 25);
            label10.TabIndex = 16;
            label10.Text = "Description:";
            // 
            // panel1
            // 
            panel1.Controls.Add(S_E_Category_ListBox);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(S_E_ID);
            panel1.Controls.Add(S_E_Quantity_TextFiled);
            panel1.Controls.Add(S_E_Penality_TextFiled);
            panel1.Controls.Add(S_E_Condition_TextFiled);
            panel1.Controls.Add(S_E_Description_RichTextFiled);
            panel1.Controls.Add(S_E_Status_TextFiled);
            panel1.Controls.Add(S_E_Price_TextFiled);
            panel1.Controls.Add(S_E_EquipmentName_TextFiled);
            panel1.Location = new Point(468, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 535);
            panel1.TabIndex = 8;
            // 
            // S_E_Category_ListBox
            // 
            S_E_Category_ListBox.Enabled = false;
            S_E_Category_ListBox.FormattingEnabled = true;
            S_E_Category_ListBox.ItemHeight = 25;
            S_E_Category_ListBox.Items.AddRange(new object[] { "For Update" });
            S_E_Category_ListBox.Location = new Point(270, 178);
            S_E_Category_ListBox.Name = "S_E_Category_ListBox";
            S_E_Category_ListBox.Size = new Size(216, 29);
            S_E_Category_ListBox.TabIndex = 18;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Enabled = false;
            button2.Location = new Point(175, 490);
            button2.Name = "button2";
            button2.Size = new Size(161, 33);
            button2.TabIndex = 17;
            button2.Text = "Conform Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // Admin2_StoreEquipment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SearchBar_TextFiled);
            Controls.Add(E_AddNew_Button);
            Controls.Add(S_E_Update_Button);
            Controls.Add(label2);
            Controls.Add(S_E_Delete_Button);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(Store_E_GridTabel);
            Name = "Admin2_StoreEquipment";
            Size = new Size(1001, 670);
            Load += Admin2_StoreEquipment_Load;
            ((System.ComponentModel.ISupportInitialize)Store_E_GridTabel).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button E_AddNew_Button;
        private Button S_E_Update_Button;
        private Label label2;
        private Button S_E_Delete_Button;
        private Label label1;
        private DataGridView Store_E_GridTabel;
        private DataGridViewTextBoxColumn E_ID;
        private DataGridViewTextBoxColumn E_Name;
        private DataGridViewTextBoxColumn E_RentalPrice;
        private DataGridViewTextBoxColumn E_Quantity;
        private TextBox SearchBar_TextFiled;
        private TextBox S_E_EquipmentName_TextFiled;
        private TextBox S_E_Price_TextFiled;
        private TextBox S_E_Status_TextFiled;
        private RichTextBox S_E_Description_RichTextFiled;
        private TextBox S_E_Condition_TextFiled;
        private TextBox S_E_Penality_TextFiled;
        private TextBox S_E_Quantity_TextFiled;
        private Label S_E_ID;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel1;
        private Button button2;
        private ListBox S_E_Category_ListBox;
    }
}
