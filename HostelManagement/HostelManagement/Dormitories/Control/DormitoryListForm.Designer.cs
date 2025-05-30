namespace HostelManagement.Dormitories
{
    partial class DormitoryListForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private DataGridView dgvDormitories;
        private Button btnBack;

        private void InitializeComponent()
        {
            dgvDormitories = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDormitories).BeginInit();
            SuspendLayout();
            // 
            // dgvDormitories
            // 
            dgvDormitories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDormitories.Location = new Point(20, 20);
            dgvDormitories.Name = "dgvDormitories";
            dgvDormitories.ReadOnly = true;
            dgvDormitories.RowHeadersVisible = false;
            dgvDormitories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDormitories.Size = new Size(740, 300);
            dgvDormitories.TabIndex = 0;

            dgvDormitories.Columns.Add("Name", "Dormitory Name");
            dgvDormitories.Columns.Add("Address", "Address");
            dgvDormitories.Columns.Add("Capacity", "Total Capacity");
            dgvDormitories.Columns.Add("Manager", "Manager");
            dgvDormitories.Columns.Add("Blocks", "Blocks");
            // 
            // btnBack
            // 
            btnBack.Location = new Point(20, 340);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 40);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += BtnBack_Click;
            // 
            // DormitoryListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 400);
            Controls.Add(dgvDormitories);
            Controls.Add(btnBack);
            Name = "DormitoryListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dormitory List";
            Load += DormitoryListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDormitories).EndInit();
            ResumeLayout(false);
        }
    }
}
