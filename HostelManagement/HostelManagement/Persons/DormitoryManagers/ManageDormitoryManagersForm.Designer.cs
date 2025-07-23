namespace HostelManagement.Persons.DormitoryManagers
{
    partial class ManageDormitoryManagersForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lstManagers = new ListBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lstManagers
            // 
            lstManagers.FormattingEnabled = true;
            lstManagers.ItemHeight = 25;
            lstManagers.Location = new Point(29, 33);
            lstManagers.Margin = new Padding(4, 5, 4, 5);
            lstManagers.Name = "lstManagers";
            lstManagers.Size = new Size(484, 304);
            lstManagers.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(151, 367);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 50);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(274, 367);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 50);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(398, 367);
            btnBack.Margin = new Padding(4, 5, 4, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(115, 50);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(29, 367);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 50);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ManageDormitoryManagersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 452);
            Controls.Add(btnAdd);
            Controls.Add(lstManagers);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ManageDormitoryManagersForm";
            Text = "Manage Dormitory Managers";
            Load += ManageDormitoryManagersForm_Load;
            ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox lstManagers;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private Button btnAdd;
    }
}
