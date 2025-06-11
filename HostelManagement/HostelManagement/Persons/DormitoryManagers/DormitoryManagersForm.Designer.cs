namespace HostelManagement.People
{
    partial class DormitoryManagersForm
    {
        private System.ComponentModel.IContainer components = null;

        private Button BtnAdd;
        private Button BtnEdit;
        private Button BtnDelete;
        private Button BtnView;
        private Button BtnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            BtnAdd = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnView = new Button();
            BtnBack = new Button();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(50, 30);
            BtnAdd.Size = new Size(300, 40);
            BtnAdd.Text = "Add Dormitory Manager";
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Location = new Point(50, 80);
            BtnEdit.Size = new Size(300, 40);
            BtnEdit.Text = "Edit Dormitory Manager";
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(50, 130);
            BtnDelete.Size = new Size(300, 40);
            BtnDelete.Text = "Delete Dormitory Manager";
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnView
            // 
            BtnView.Location = new Point(50, 180);
            BtnView.Size = new Size(300, 40);
            BtnView.Text = "View Dormitory Managers";
            BtnView.Click += BtnView_Click;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(50, 230);
            BtnBack.Size = new Size(300, 40);
            BtnBack.Text = "Back";
            BtnBack.Click += BtnBack_Click;
            // 
            // DormitoryManagersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 320);
            Controls.Add(BtnAdd);
            Controls.Add(BtnEdit);
            Controls.Add(BtnDelete);
            Controls.Add(BtnView);
            Controls.Add(BtnBack);
            Name = "DormitoryManagersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dormitory Managers";
            ResumeLayout(false);
        }
    }
}
