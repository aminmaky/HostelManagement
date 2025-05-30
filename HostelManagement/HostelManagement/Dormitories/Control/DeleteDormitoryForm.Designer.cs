namespace HostelManagement.Dormitories
{
    partial class DeleteDormitoryForm
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

        private ComboBox cmbDormitories;
        private Button btnDelete;
        private Button btnBack;

        private void InitializeComponent()
        {
            cmbDormitories = new ComboBox();
            btnDelete = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // cmbDormitories
            // 
            cmbDormitories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDormitories.FormattingEnabled = true;
            cmbDormitories.Location = new Point(40, 40);
            cmbDormitories.Name = "cmbDormitories";
            cmbDormitories.Size = new Size(300, 33);
            cmbDormitories.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(40, 100);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 45);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(200, 100);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 45);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += BtnBack_Click;
            // 
            // DeleteDormitoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 180);
            Controls.Add(cmbDormitories);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Name = "DeleteDormitoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete Dormitory";
            Load += DeleteDormitoryForm_Load;
            ResumeLayout(false);
        }
    }
}
