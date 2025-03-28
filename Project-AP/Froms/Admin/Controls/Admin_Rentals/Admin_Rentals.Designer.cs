namespace Project_AP.From.Admin.Controls.Admin_Rentals
{
    partial class Admin_Rentals
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
            R_Requests = new Button();
            R_RentalsTrack = new Button();
            R_HistoryReport = new Button();
            rentals_HistoryReport1 = new Project_AP.From.Admin.Controls.Rentals_Controls.Rentals_HistoryReport();
            rentals_Requests1 = new Project_AP.From.Admin.Controls.Rentals_Controls.Rentals_Requests();
            rentals_Tracking1 = new Project_AP.From.Admin.Controls.Rentals_Controls.Rentals_Tracking();
            SuspendLayout();
            // 
            // R_Requests
            // 
            R_Requests.BackColor = Color.DarkGray;
            R_Requests.Location = new Point(113, 3);
            R_Requests.Name = "R_Requests";
            R_Requests.Size = new Size(268, 60);
            R_Requests.TabIndex = 0;
            R_Requests.Text = "Rental Requests";
            R_Requests.UseVisualStyleBackColor = false;
            R_Requests.Click += R_Requests_Click;
            // 
            // R_RentalsTrack
            // 
            R_RentalsTrack.BackColor = Color.FromArgb(255, 192, 128);
            R_RentalsTrack.Location = new Point(377, 3);
            R_RentalsTrack.Name = "R_RentalsTrack";
            R_RentalsTrack.Size = new Size(268, 60);
            R_RentalsTrack.TabIndex = 1;
            R_RentalsTrack.Text = "Rentals Track";
            R_RentalsTrack.UseVisualStyleBackColor = false;
            R_RentalsTrack.Click += R_RentalsTrack_Click;
            // 
            // R_HistoryReport
            // 
            R_HistoryReport.BackColor = Color.Purple;
            R_HistoryReport.Location = new Point(641, 3);
            R_HistoryReport.Name = "R_HistoryReport";
            R_HistoryReport.Size = new Size(268, 60);
            R_HistoryReport.TabIndex = 2;
            R_HistoryReport.Text = "Rentals History";
            R_HistoryReport.UseVisualStyleBackColor = false;
            R_HistoryReport.Click += R_HistoryReport_Click;
            // 
            // rentals_HistoryReport1
            // 
            rentals_HistoryReport1.BackColor = Color.WhiteSmoke;
            rentals_HistoryReport1.Location = new Point(0, 66);
            rentals_HistoryReport1.Name = "rentals_HistoryReport1";
            rentals_HistoryReport1.Size = new Size(1001, 604);
            rentals_HistoryReport1.TabIndex = 3;
            // 
            // rentals_Requests1
            // 
            rentals_Requests1.BackColor = Color.WhiteSmoke;
            rentals_Requests1.Location = new Point(0, 66);
            rentals_Requests1.Name = "rentals_Requests1";
            rentals_Requests1.Size = new Size(1001, 613);
            rentals_Requests1.TabIndex = 4;
            // 
            // rentals_Tracking1
            // 
            rentals_Tracking1.BackColor = Color.WhiteSmoke;
            rentals_Tracking1.Location = new Point(0, 66);
            rentals_Tracking1.Name = "rentals_Tracking1";
            rentals_Tracking1.Size = new Size(1001, 604);
            rentals_Tracking1.TabIndex = 5;
            // 
            // Admin_Rentals
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rentals_Tracking1);
            Controls.Add(rentals_Requests1);
            Controls.Add(rentals_HistoryReport1);
            Controls.Add(R_HistoryReport);
            Controls.Add(R_RentalsTrack);
            Controls.Add(R_Requests);
            Name = "Admin_Rentals";
            Size = new Size(1001, 670);
            Load += Admin_Rentals_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button R_Requests;
        private Button R_RentalsTrack;
        private Button R_HistoryReport;
        private Rentals_Controls.Rentals_HistoryReport rentals_HistoryReport1;
        private Rentals_Controls.Rentals_Requests rentals_Requests1;
        private Rentals_Controls.Rentals_Tracking rentals_Tracking1;
    }
}
