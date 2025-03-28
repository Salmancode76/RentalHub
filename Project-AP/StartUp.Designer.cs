namespace Project_AP
{
    partial class StartUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUp));
            pictureBox1 = new PictureBox();
            LogIn_Button = new Button();
            label3 = new Label();
            label2 = new Label();
            Password_TextBox = new TextBox();
            UserName_TextBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1258, 673);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // LogIn_Button
            // 
            LogIn_Button.BackColor = Color.FromArgb(28, 28, 43);
            LogIn_Button.FlatAppearance.BorderColor = SystemColors.InfoText;
            LogIn_Button.Font = new Font("Palatino Linotype", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LogIn_Button.ForeColor = Color.White;
            LogIn_Button.Location = new Point(551, 466);
            LogIn_Button.Name = "LogIn_Button";
            LogIn_Button.Size = new Size(191, 61);
            LogIn_Button.TabIndex = 27;
            LogIn_Button.Text = "LOGIN";
            LogIn_Button.UseVisualStyleBackColor = false;
            LogIn_Button.Click += LogIn_Button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("PMingLiU-ExtB", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(455, 356);
            label3.Name = "label3";
            label3.Size = new Size(103, 22);
            label3.TabIndex = 26;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PMingLiU-ExtB", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(455, 259);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 25;
            label2.Text = "User Name:";
            // 
            // Password_TextBox
            // 
            Password_TextBox.BackColor = Color.FromArgb(28, 28, 43);
            Password_TextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Password_TextBox.ForeColor = Color.WhiteSmoke;
            Password_TextBox.Location = new Point(455, 381);
            Password_TextBox.Multiline = true;
            Password_TextBox.Name = "Password_TextBox";
            Password_TextBox.PasswordChar = '*';
            Password_TextBox.Size = new Size(372, 46);
            Password_TextBox.TabIndex = 24;
            // 
            // UserName_TextBox
            // 
            UserName_TextBox.BackColor = Color.FromArgb(28, 28, 43);
            UserName_TextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserName_TextBox.ForeColor = Color.WhiteSmoke;
            UserName_TextBox.Location = new Point(455, 284);
            UserName_TextBox.Multiline = true;
            UserName_TextBox.Name = "UserName_TextBox";
            UserName_TextBox.Size = new Size(372, 46);
            UserName_TextBox.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(433, 140);
            label1.Name = "label1";
            label1.Size = new Size(405, 87);
            label1.TabIndex = 22;
            label1.Text = "Register";
            // 
            // StartUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 673);
            Controls.Add(LogIn_Button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Password_TextBox);
            Controls.Add(UserName_TextBox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "StartUp";
            Text = "StartUp";
            Load += StartUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button LogIn_Button;
        private Label label3;
        private Label label2;
        private TextBox Password_TextBox;
        private TextBox UserName_TextBox;
        private Label label1;
    }
}