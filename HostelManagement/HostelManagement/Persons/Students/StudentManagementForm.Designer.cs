namespace HostelManagement.Persons.Students
{
    partial class StudentManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lstStudents = new ListBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnViewDetails = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRegister = new Button();
            btnTransfer = new Button();
            lblTitle = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 25;
            lstStudents.Location = new Point(15, 51);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(300, 279);
            lstStudents.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(340, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 45);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Student";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(340, 81);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 45);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit Student";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(340, 132);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 45);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Student";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnViewDetails
            // 
            btnViewDetails.Location = new Point(340, 183);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(150, 45);
            btnViewDetails.TabIndex = 5;
            btnViewDetails.Text = "View Full Details";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(15, 350);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(220, 31);
            txtSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(250, 350);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 31);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(340, 234);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 45);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register Student";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.Location = new Point(340, 285);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(150, 45);
            btnTransfer.TabIndex = 9;
            btnTransfer.Text = "Transfer Student";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(260, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Management";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(375, 350);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(115, 31);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // StudentManagementForm
            // 
            ClientSize = new Size(514, 400);
            Controls.Add(btnBack);
            Controls.Add(lblTitle);
            Controls.Add(lstStudents);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnViewDetails);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnRegister);
            Controls.Add(btnTransfer);
            Name = "StudentManagementForm";
            Text = "Student Management";
            Load += StudentManagementForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnBack;
    }
}
