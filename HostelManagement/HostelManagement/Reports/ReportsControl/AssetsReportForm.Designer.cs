namespace HostelManagement.Reports
{
    partial class AssetsReportForm
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox cmbReportType;
        private Button btnShowReport;
        private DataGridView dgvReport;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbReportType = new ComboBox();
            btnShowReport = new Button();
            dgvReport = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // cmbReportType
            // 
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.Items.AddRange(new object[] { "All Assets", "Assets Per Room", "Assets Per Student", "Broken & Repairing Assets" });
            cmbReportType.Location = new Point(30, 30);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(250, 33);
            cmbReportType.TabIndex = 0;
            // 
            // btnShowReport
            // 
            btnShowReport.Location = new Point(345, 30);
            btnShowReport.Name = "btnShowReport";
            btnShowReport.Size = new Size(120, 35);
            btnShowReport.TabIndex = 1;
            btnShowReport.Text = "Show Report";
            btnShowReport.Click += BtnShowReport_Click;
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.ColumnHeadersHeight = 34;
            dgvReport.Location = new Point(30, 80);
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersWidth = 62;
            dgvReport.Size = new Size(600, 300);
            dgvReport.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(510, 30);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 35);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AssetsReportForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 420);
            Controls.Add(btnBack);
            Controls.Add(cmbReportType);
            Controls.Add(btnShowReport);
            Controls.Add(dgvReport);
            Name = "AssetsReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assets Report";
            Load += AssetsReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
        }

        private Button btnBack;
    }
}
