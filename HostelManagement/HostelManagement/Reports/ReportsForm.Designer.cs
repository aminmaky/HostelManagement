namespace HostelManagement.Reports
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private Button BtnHousingStatusReport;
        private Button BtnAssetsReport;
        private Button BtnRepairRequestsReport;

        private void InitializeComponent()
        {
            BtnHousingStatusReport = new Button();
            BtnAssetsReport = new Button();
            BtnRepairRequestsReport = new Button();
            BtnBack = new Button();
            BtnStudentHousingHistory = new Button();
            SuspendLayout();
            // 
            // BtnHousingStatusReport
            // 
            BtnHousingStatusReport.Location = new Point(60, 30);
            BtnHousingStatusReport.Name = "BtnHousingStatusReport";
            BtnHousingStatusReport.Size = new Size(320, 50);
            BtnHousingStatusReport.TabIndex = 0;
            BtnHousingStatusReport.Text = "Housing Status Report";
            BtnHousingStatusReport.UseVisualStyleBackColor = true;
            BtnHousingStatusReport.Click += BtnHousingStatusReport_Click;
            // 
            // BtnAssetsReport
            // 
            BtnAssetsReport.Location = new Point(60, 100);
            BtnAssetsReport.Name = "BtnAssetsReport";
            BtnAssetsReport.Size = new Size(320, 50);
            BtnAssetsReport.TabIndex = 1;
            BtnAssetsReport.Text = "Assets Report";
            BtnAssetsReport.UseVisualStyleBackColor = true;
            BtnAssetsReport.Click += BtnAssetsReport_Click;
            // 
            // BtnRepairRequestsReport
            // 
            BtnRepairRequestsReport.Location = new Point(60, 170);
            BtnRepairRequestsReport.Name = "BtnRepairRequestsReport";
            BtnRepairRequestsReport.Size = new Size(320, 50);
            BtnRepairRequestsReport.TabIndex = 2;
            BtnRepairRequestsReport.Text = "Repair Requests Report";
            BtnRepairRequestsReport.UseVisualStyleBackColor = true;
            BtnRepairRequestsReport.Click += BtnSpecialReports_Click;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(60, 310);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(320, 50);
            BtnBack.TabIndex = 3;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnStudentHousingHistory
            // 
            BtnStudentHousingHistory.Location = new Point(60, 240);
            BtnStudentHousingHistory.Name = "BtnStudentHousingHistory";
            BtnStudentHousingHistory.Size = new Size(320, 50);
            BtnStudentHousingHistory.TabIndex = 4;
            BtnStudentHousingHistory.Text = "Student Housing History";
            BtnStudentHousingHistory.UseVisualStyleBackColor = true;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 400);
            Controls.Add(BtnStudentHousingHistory);
            Controls.Add(BtnBack);
            Controls.Add(BtnHousingStatusReport);
            Controls.Add(BtnAssetsReport);
            Controls.Add(BtnRepairRequestsReport);
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            Load += ReportsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnBack;
        private Button BtnStudentHousingHistory;
    }
}
