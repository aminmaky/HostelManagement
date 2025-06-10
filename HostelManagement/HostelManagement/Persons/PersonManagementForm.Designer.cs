using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HostelManagement.People
{
    partial class PersonManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        private Button BtnDormitoryManagers;
        private Button BtnBlockManagers;
        private Button BtnStudents;
        private Button BtnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            BtnDormitoryManagers = new Button();
            BtnBlockManagers = new Button();
            BtnStudents = new Button();
            BtnBack = new Button();
            SuspendLayout();
            // 
            // BtnDormitoryManagers
            // 
            BtnDormitoryManagers.Location = new Point(60, 40);
            BtnDormitoryManagers.Name = "BtnDormitoryManagers";
            BtnDormitoryManagers.Size = new Size(300, 45);
            BtnDormitoryManagers.TabIndex = 0;
            BtnDormitoryManagers.Text = "Dormitory Managers";
            BtnDormitoryManagers.Click += BtnDormitoryManagers_Click;
            // 
            // BtnBlockManagers
            // 
            BtnBlockManagers.Location = new Point(60, 95);
            BtnBlockManagers.Name = "BtnBlockManagers";
            BtnBlockManagers.Size = new Size(300, 45);
            BtnBlockManagers.TabIndex = 1;
            BtnBlockManagers.Text = "Block Managers";
            BtnBlockManagers.Click += BtnBlockManagers_Click;
            // 
            // BtnStudents
            // 
            BtnStudents.Location = new Point(60, 150);
            BtnStudents.Name = "BtnStudents";
            BtnStudents.Size = new Size(300, 45);
            BtnStudents.TabIndex = 2;
            BtnStudents.Text = "Students";
            BtnStudents.Click += BtnStudents_Click;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(60, 205);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(300, 45);
            BtnBack.TabIndex = 3;
            BtnBack.Text = "Back";
            BtnBack.Click += BtnBackToMain_Click;
            // 
            // PersonManagementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 300);
            Controls.Add(BtnDormitoryManagers);
            Controls.Add(BtnBlockManagers);
            Controls.Add(BtnStudents);
            Controls.Add(BtnBack);
            Name = "PersonManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Person Management";
            ResumeLayout(false);
        }
    }
}
