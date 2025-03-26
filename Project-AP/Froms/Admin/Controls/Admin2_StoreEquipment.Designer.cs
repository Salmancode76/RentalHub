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
            S_E_AddNew_Button = new Button();
            S_E_Update_Button = new Button();
            label2 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            richTextBox1 = new RichTextBox();
            S_E_Delete_Button = new Button();
            label1 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            S_E_ID = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            Store_E_GridTabel = new DataGridView();
            E_ID = new DataGridViewTextBoxColumn();
            E_Name = new DataGridViewTextBoxColumn();
            E_RentalPrice = new DataGridViewTextBoxColumn();
            E_Quantity = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Store_E_GridTabel).BeginInit();
            SuspendLayout();
            // 
            // S_E_AddNew_Button
            // 
            S_E_AddNew_Button.Location = new Point(814, 578);
            S_E_AddNew_Button.Name = "S_E_AddNew_Button";
            S_E_AddNew_Button.Size = new Size(127, 56);
            S_E_AddNew_Button.TabIndex = 13;
            S_E_AddNew_Button.Text = "Add New";
            S_E_AddNew_Button.UseVisualStyleBackColor = true;
            S_E_AddNew_Button.Click += S_E_AddNew_Button_Click;
            // 
            // S_E_Update_Button
            // 
            S_E_Update_Button.Location = new Point(519, 578);
            S_E_Update_Button.Name = "S_E_Update_Button";
            S_E_Update_Button.Size = new Size(134, 56);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(31, 224);
            label7.Name = "label7";
            label7.Size = new Size(94, 25);
            label7.TabIndex = 13;
            label7.Text = "Condition:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(151, 315);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(222, 31);
            textBox7.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(264, 247);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(222, 31);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(27, 247);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(222, 31);
            textBox6.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(70, 387);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(380, 97);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // S_E_Delete_Button
            // 
            S_E_Delete_Button.Location = new Point(668, 577);
            S_E_Delete_Button.Name = "S_E_Delete_Button";
            S_E_Delete_Button.Size = new Size(130, 57);
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
            // textBox4
            // 
            textBox4.Location = new Point(264, 176);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(222, 31);
            textBox4.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(S_E_ID);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(468, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 510);
            panel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(31, 149);
            label5.Name = "label5";
            label5.Size = new Size(159, 25);
            label5.TabIndex = 11;
            label5.Text = "Availability Status:";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(31, 87);
            label3.Name = "label3";
            label3.Size = new Size(153, 25);
            label3.TabIndex = 9;
            label3.Text = "Equipment Name:";
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
            // textBox3
            // 
            textBox3.Location = new Point(27, 176);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(222, 31);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(264, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 31);
            textBox1.TabIndex = 0;
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
            // Admin2_StoreEquipment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(S_E_AddNew_Button);
            Controls.Add(S_E_Update_Button);
            Controls.Add(label2);
            Controls.Add(S_E_Delete_Button);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(Store_E_GridTabel);
            Name = "Admin2_StoreEquipment";
            Size = new Size(1001, 670);
            Load += Admin2_StoreEquipment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Store_E_GridTabel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button S_E_AddNew_Button;
        private Button S_E_Update_Button;
        private Label label2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBox7;
        private TextBox textBox5;
        private TextBox textBox6;
        private RichTextBox richTextBox1;
        private Button S_E_Delete_Button;
        private Label label1;
        private Label label6;
        private TextBox textBox4;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label S_E_ID;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView Store_E_GridTabel;
        private DataGridViewTextBoxColumn E_ID;
        private DataGridViewTextBoxColumn E_Name;
        private DataGridViewTextBoxColumn E_RentalPrice;
        private DataGridViewTextBoxColumn E_Quantity;
    }
}
