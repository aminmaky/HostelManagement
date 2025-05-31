namespace HostelManagement.Blocks
{
    partial class DeleteBlockForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private Label lblDormitory;
        private ListBox lstBlocks;
        private Button btnDelete;
        private Button btnCancel;

        private void InitializeComponent()
        {
            lblDormitory = new Label();
            lstBlocks = new ListBox();
            btnDelete = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblDormitory
            // 
            lblDormitory.AutoSize = true;
            lblDormitory.Location = new Point(20, 20);
            lblDormitory.Size = new Size(300, 25);
            lblDormitory.Text = "Dormitory: ";
            // 
            // lstBlocks
            // 
            lstBlocks.Location = new Point(20, 60);
            lstBlocks.Size = new Size(350, 120);
            // 
            // btnDelete
            // 
            btnDelete.Text = "Delete";
            btnDelete.Location = new Point(20, 200);
            btnDelete.Size = new Size(170, 40);
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Text = "Cancel";
            btnCancel.Location = new Point(200, 200);
            btnCancel.Size = new Size(170, 40);
            btnCancel.Click += BtnCancel_Click;
            // 
            // DeleteBlockForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 270);
            Controls.Add(lblDormitory);
            Controls.Add(lstBlocks);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Name = "DeleteBlockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete Block";
            Load += DeleteBlockForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
