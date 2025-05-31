namespace HostelManagement.Blocks
{
    partial class BlockListForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private Label lblDormitory;
        private DataGridView dgvBlocks;
        private Button btnClose;

        private void InitializeComponent()
        {
            lblDormitory = new Label();
            dgvBlocks = new DataGridView();
            btnClose = new Button();

            ((System.ComponentModel.ISupportInitialize)(dgvBlocks)).BeginInit();
            SuspendLayout();
            // 
            // lblDormitory
            // 
            lblDormitory.AutoSize = true;
            lblDormitory.Location = new Point(20, 20);
            lblDormitory.Text = "Dormitory: ";
            // 
            // dgvBlocks
            // 
            dgvBlocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBlocks.Location = new Point(20, 60);
            dgvBlocks.Size = new Size(540, 300);
            dgvBlocks.ReadOnly = true;
            dgvBlocks.AllowUserToAddRows = false;
            dgvBlocks.AllowUserToDeleteRows = false;
            dgvBlocks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvBlocks.Columns.Add("BlockName", "Block Name");
            dgvBlocks.Columns.Add("Floors", "Floors");
            dgvBlocks.Columns.Add("Rooms", "Rooms");
            dgvBlocks.Columns.Add("Manager", "Manager");
            // 
            // btnClose
            // 
            btnClose.Location = new Point(230, 380);
            btnClose.Size = new Size(130, 40);
            btnClose.Text = "Close";
            btnClose.Click += BtnClose_Click;
            // 
            // BlockListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 450);
            Controls.Add(lblDormitory);
            Controls.Add(dgvBlocks);
            Controls.Add(btnClose);
            Name = "BlockListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Block List";
            Load += BlockListForm_Load;
            ((System.ComponentModel.ISupportInitialize)(dgvBlocks)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
