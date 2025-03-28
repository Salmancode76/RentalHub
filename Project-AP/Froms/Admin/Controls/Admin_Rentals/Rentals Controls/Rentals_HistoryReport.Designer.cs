namespace Project_AP.From.Admin.Controls.Rentals_Controls
{
    partial class Rentals_HistoryReport
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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(381, 176);
            button1.Name = "button1";
            button1.Size = new Size(266, 222);
            button1.TabIndex = 0;
            button1.Text = "Generate Report ?";
            button1.UseVisualStyleBackColor = true;
            // 
            // Rentals_HistoryReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            Controls.Add(button1);
            Name = "Rentals_HistoryReport";
            Size = new Size(1001, 618);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}
