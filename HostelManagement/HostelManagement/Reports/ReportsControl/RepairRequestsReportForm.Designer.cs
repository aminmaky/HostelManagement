using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HostelManagement.Reports
{
    partial class RepairRequestsReportForm
    {
        private System.ComponentModel.IContainer components = null;

        private DataGridView dgvRepairRequests;
        private Button btnLoadRequests;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvRepairRequests = new DataGridView();
            btnLoadRequests = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRepairRequests).BeginInit();
            SuspendLayout();
            // 
            // dgvRepairRequests
            // 
            dgvRepairRequests.AllowUserToAddRows = false;
            dgvRepairRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRepairRequests.ColumnHeadersHeight = 34;
            dgvRepairRequests.Location = new Point(30, 80);
            dgvRepairRequests.Name = "dgvRepairRequests";
            dgvRepairRequests.ReadOnly = true;
            dgvRepairRequests.RowHeadersWidth = 62;
            dgvRepairRequests.Size = new Size(720, 320);
            dgvRepairRequests.TabIndex = 1;
            // 
            // btnLoadRequests
            // 
            btnLoadRequests.Location = new Point(30, 25);
            btnLoadRequests.Name = "btnLoadRequests";
            btnLoadRequests.Size = new Size(200, 35);
            btnLoadRequests.TabIndex = 0;
            btnLoadRequests.Text = "Load Repair Requests";
            btnLoadRequests.Click += BtnLoadRequests_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(255, 25);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(115, 35);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // RepairRequestsReportForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 430);
            Controls.Add(btnBack);
            Controls.Add(btnLoadRequests);
            Controls.Add(dgvRepairRequests);
            Name = "RepairRequestsReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Repair Requests Report";
            Load += RepairRequestsReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRepairRequests).EndInit();
            ResumeLayout(false);
        }

        private Button btnBack;
    }
}
