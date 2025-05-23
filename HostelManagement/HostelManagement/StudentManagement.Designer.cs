namespace HostelManagement
{
    partial class StudentManagement
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

        private Button btnAddStudent;
        private Button btnDeleteStudent;
        private Button btnEditStudent;
        private Button btnSearchStudent;
        private Button btnViewStudentInfo;
        private Button btnAssignDorm;
        private Button btnTransferStudent;

        private void InitializeComponent()
        {
            btnAddStudent = new Button();
            btnDeleteStudent = new Button();
            btnEditStudent = new Button();
            btnSearchStudent = new Button();
            btnViewStudentInfo = new Button();
            btnAssignDorm = new Button();
            btnTransferStudent = new Button();
            SuspendLayout();
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(50, 30);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(200, 40);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(50, 80);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(200, 40);
            btnDeleteStudent.TabIndex = 1;
            btnDeleteStudent.Text = "Delete Student";
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // btnEditStudent
            // 
            btnEditStudent.Location = new Point(50, 130);
            btnEditStudent.Name = "btnEditStudent";
            btnEditStudent.Size = new Size(200, 40);
            btnEditStudent.TabIndex = 2;
            btnEditStudent.Text = "Edit Student";
            btnEditStudent.Click += btnEditStudent_Click;
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.Location = new Point(50, 180);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(200, 40);
            btnSearchStudent.TabIndex = 3;
            btnSearchStudent.Text = "Search Student";
            btnSearchStudent.Click += btnSearchStudent_Click;
            // 
            // btnViewStudentInfo
            // 
            btnViewStudentInfo.Location = new Point(50, 230);
            btnViewStudentInfo.Name = "btnViewStudentInfo";
            btnViewStudentInfo.Size = new Size(200, 40);
            btnViewStudentInfo.TabIndex = 4;
            btnViewStudentInfo.Text = "View Full Info";
            btnViewStudentInfo.Click += btnViewStudentInfo_Click;
            // 
            // btnAssignDorm
            // 
            btnAssignDorm.Location = new Point(50, 280);
            btnAssignDorm.Name = "btnAssignDorm";
            btnAssignDorm.Size = new Size(200, 40);
            btnAssignDorm.TabIndex = 5;
            btnAssignDorm.Text = "Assign to Dorm";
            btnAssignDorm.Click += btnAssignDorm_Click;
            // 
            // btnTransferStudent
            // 
            btnTransferStudent.Location = new Point(50, 330);
            btnTransferStudent.Name = "btnTransferStudent";
            btnTransferStudent.Size = new Size(200, 40);
            btnTransferStudent.TabIndex = 6;
            btnTransferStudent.Text = "Transfer Student";
            btnTransferStudent.Click += btnTransferStudent_Click;
            // 
            // StudentManagement
            // 
            ClientSize = new Size(300, 420);
            Controls.Add(btnAddStudent);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnEditStudent);
            Controls.Add(btnSearchStudent);
            Controls.Add(btnViewStudentInfo);
            Controls.Add(btnAssignDorm);
            Controls.Add(btnTransferStudent);
            Name = "StudentManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Management";
            ResumeLayout(false);
        }


        #endregion
    }
}