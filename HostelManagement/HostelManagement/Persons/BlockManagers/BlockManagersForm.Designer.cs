namespace HostelManagement.Persons.BlockManagers
{
    partial class BlockManagersForm
    {
        private System.Windows.Forms.ListBox lstBlockManagers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChangeBlockManager;
        private System.Windows.Forms.ComboBox cmbDormitoryManagers;
        private System.Windows.Forms.Label lblSelectDormitoryManager;

        private void InitializeComponent()
        {
            lstBlockManagers = new ListBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnChangeBlockManager = new Button();
            cmbDormitoryManagers = new ComboBox();
            lblSelectDormitoryManager = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lstBlockManagers
            // 
            lstBlockManagers.FormattingEnabled = true;
            lstBlockManagers.ItemHeight = 25;
            lstBlockManagers.Location = new Point(30, 30);
            lstBlockManagers.Name = "lstBlockManagers";
            lstBlockManagers.Size = new Size(300, 179);
            lstBlockManagers.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(336, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 47);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Block Manager";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(336, 83);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(200, 47);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Block Manager";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChangeBlockManager
            // 
            btnChangeBlockManager.Location = new Point(336, 225);
            btnChangeBlockManager.Name = "btnChangeBlockManager";
            btnChangeBlockManager.Size = new Size(192, 58);
            btnChangeBlockManager.TabIndex = 5;
            btnChangeBlockManager.Text = "Change Block Manager";
            btnChangeBlockManager.Click += btnChangeDormitoryManager_Click;
            // 
            // cmbDormitoryManagers
            // 
            cmbDormitoryManagers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDormitoryManagers.Location = new Point(30, 250);
            cmbDormitoryManagers.Name = "cmbDormitoryManagers";
            cmbDormitoryManagers.Size = new Size(300, 33);
            cmbDormitoryManagers.TabIndex = 4;
            // 
            // lblSelectDormitoryManager
            // 
            lblSelectDormitoryManager.AutoSize = true;
            lblSelectDormitoryManager.Location = new Point(30, 230);
            lblSelectDormitoryManager.Name = "lblSelectDormitoryManager";
            lblSelectDormitoryManager.Size = new Size(224, 25);
            lblSelectDormitoryManager.TabIndex = 3;
            lblSelectDormitoryManager.Text = "Select New Block Manager:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(336, 162);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(200, 47);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // BlockManagersForm
            // 
            ClientSize = new Size(540, 320);
            Controls.Add(btnBack);
            Controls.Add(lstBlockManagers);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(lblSelectDormitoryManager);
            Controls.Add(cmbDormitoryManagers);
            Controls.Add(btnChangeBlockManager);
            Name = "BlockManagersForm";
            Text = "Block Managers Management";
            Load += BlockManagersForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnBack;
    }
}