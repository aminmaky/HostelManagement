using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HostelManagement.Reports
{
    partial class StudentHousingHistoryForm
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox cmbStudents;
        private Button btnLoadHistory;
        private DataGridView dgvHistory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbStudents = new ComboBox();
            btnLoadHistory = new Button();
            dgvHistory = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // cmbStudents
            // 
            cmbStudents.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudents.Location = new Point(30, 30);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(300, 33);
            cmbStudents.TabIndex = 0;
            // 
            // btnLoadHistory
            // 
            btnLoadHistory.Location = new Point(350, 30);
            btnLoadHistory.Name = "btnLoadHistory";
            btnLoadHistory.Size = new Size(200, 35);
            btnLoadHistory.TabIndex = 1;
            btnLoadHistory.Text = "Load Housing History";
            btnLoadHistory.Click += BtnLoadHistory_Click;
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.ColumnHeadersHeight = 34;
            dgvHistory.Location = new Point(30, 90);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersWidth = 62;
            dgvHistory.Size = new Size(720, 320);
            dgvHistory.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(600, 30);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(115, 35);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // StudentHousingHistoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 450);
            Controls.Add(btnBack);
            Controls.Add(cmbStudents);
            Controls.Add(btnLoadHistory);
            Controls.Add(dgvHistory);
            Name = "StudentHousingHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Housing History";
            Load += StudentHousingHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
        }

        private Button btnBack;
    }
}
