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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)RentalsRequests_GridTable).BeginInit();
            SuspendLayout();
            // 
            // RentalsRequests_GridTable
            // 
            RentalsRequests_GridTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RentalsRequests_GridTable.Location = new Point(24, 18);
            RentalsRequests_GridTable.Name = "RentalsRequests_GridTable";
            RentalsRequests_GridTable.RowHeadersWidth = 62;
            RentalsRequests_GridTable.RowTemplate.Height = 33;
            RentalsRequests_GridTable.Size = new Size(956, 510);
            RentalsRequests_GridTable.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(358, 546);
            button1.Name = "button1";
            button1.Size = new Size(257, 53);
            button1.TabIndex = 1;
            button1.Text = "Analise Rquest";
            button1.UseVisualStyleBackColor = true;
            // 
            // Rentals_Requests
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Olive;
            Controls.Add(button1);
            Controls.Add(RentalsRequests_GridTable);
            Name = "Rentals_Requests";
            Size = new Size(1001, 618);
            ((System.ComponentModel.ISupportInitialize)RentalsRequests_GridTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView RentalsRequests_GridTable;
        private Button button1;
    }
}
