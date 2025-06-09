using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HostelManagement.Reports
{

    partial class HousingStatusReportForm
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox cmbReportType;
        private Button btnShowReport;
        private DataGridView dgvHousingReport;

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
            dgvHousingReport = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHousingReport).BeginInit();
            SuspendLayout();
            // 
            // cmbReportType
            // 
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.Items.AddRange(new object[] { "Overall Student Housing", "Empty and Occupied Rooms", "Dormitory and Block Capacities" });
            cmbReportType.Location = new Point(30, 30);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(300, 33);
            cmbReportType.TabIndex = 0;
            // 
            // btnShowReport
            // 
            btnShowReport.Location = new Point(350, 30);
            btnShowReport.Name = "btnShowReport";
            btnShowReport.Size = new Size(120, 35);
            btnShowReport.TabIndex = 1;
            btnShowReport.Text = "Show Report";
            btnShowReport.Click += BtnShowReport_Click;
            // 
            // dgvHousingReport
            // 
            dgvHousingReport.AllowUserToAddRows = false;
            dgvHousingReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHousingReport.ColumnHeadersHeight = 34;
            dgvHousingReport.Location = new Point(30, 80);
            dgvHousingReport.Name = "dgvHousingReport";
            dgvHousingReport.ReadOnly = true;
            dgvHousingReport.RowHeadersWidth = 62;
            dgvHousingReport.Size = new Size(640, 320);
            dgvHousingReport.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(550, 30);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 35);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // HousingStatusReportForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 430);
            Controls.Add(btnBack);
            Controls.Add(cmbReportType);
            Controls.Add(btnShowReport);
            Controls.Add(dgvHousingReport);
            Name = "HousingStatusReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Housing Status Report";
            Load += HousingStatusReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHousingReport).EndInit();
            ResumeLayout(false);
        }

        private Button btnBack;
    }
}
