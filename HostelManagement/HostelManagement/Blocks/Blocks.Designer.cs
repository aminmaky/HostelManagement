namespace HostelManagement.Blocks
{
    partial class BlockManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private ComboBox cmbDormitories;
        private Button btnAddBlock;
        private Button btnDeleteBlock;
        private Button btnEditBlock;
        private Button btnViewBlocks;

        private void InitializeComponent()
        {
            cmbDormitories = new ComboBox();
            btnAddBlock = new Button();
            btnDeleteBlock = new Button();
            btnEditBlock = new Button();
            btnViewBlocks = new Button();

            SuspendLayout();
            // 
            // cmbDormitories
            // 
            cmbDormitories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDormitories.Location = new Point(30, 30);
            cmbDormitories.Name = "cmbDormitories";
            cmbDormitories.Size = new Size(350, 33);
            cmbDormitories.TabIndex = 0;
            // 
            // btnAddBlock
            // 
            btnAddBlock.Location = new Point(30, 80);
            btnAddBlock.Name = "btnAddBlock";
            btnAddBlock.Size = new Size(350, 40);
            btnAddBlock.TabIndex = 1;
            btnAddBlock.Text = "Add Block";
            btnAddBlock.UseVisualStyleBackColor = true;
            btnAddBlock.Click += BtnAddBlock_Click;
            // 
            // btnDeleteBlock
            // 
            btnDeleteBlock.Location = new Point(30, 130);
            btnDeleteBlock.Name = "btnDeleteBlock";
            btnDeleteBlock.Size = new Size(350, 40);
            btnDeleteBlock.TabIndex = 2;
            btnDeleteBlock.Text = "Delete Block";
            btnDeleteBlock.UseVisualStyleBackColor = true;
            btnDeleteBlock.Click += BtnDeleteBlock_Click;
            // 
            // btnEditBlock
            // 
            btnEditBlock.Location = new Point(30, 180);
            btnEditBlock.Name = "btnEditBlock";
            btnEditBlock.Size = new Size(350, 40);
            btnEditBlock.TabIndex = 3;
            btnEditBlock.Text = "Edit Block";
            btnEditBlock.UseVisualStyleBackColor = true;
            btnEditBlock.Click += BtnEditBlock_Click;
            // 
            // btnViewBlocks
            // 
            btnViewBlocks.Location = new Point(30, 230);
            btnViewBlocks.Name = "btnViewBlocks";
            btnViewBlocks.Size = new Size(350, 40);
            btnViewBlocks.TabIndex = 4;
            btnViewBlocks.Text = "View Blocks";
            btnViewBlocks.UseVisualStyleBackColor = true;
            btnViewBlocks.Click += BtnViewBlocks_Click;
            // 
            // BlockManagementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 300);
            Controls.Add(cmbDormitories);
            Controls.Add(btnAddBlock);
            Controls.Add(btnDeleteBlock);
            Controls.Add(btnEditBlock);
            Controls.Add(btnViewBlocks);
            Name = "BlockManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Block Management";
            Load += BlockManagementForm_Load;
            ResumeLayout(false);
        }
    }
}
