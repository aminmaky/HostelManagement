namespace HostelManagement.Dormitories
{
    partial class EditDormitoryForm
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
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtCapacity;
        private Button btnSaveChanges;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;

        private void InitializeComponent()
        {
            cmbDormitories = new ComboBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtCapacity = new TextBox();
            btnSaveChanges = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnBack = new Button();
            cmbManager = new ComboBox();
            SuspendLayout();
            // 
            // cmbDormitories
            // 
            cmbDormitories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDormitories.Location = new Point(135, 30);
            cmbDormitories.Name = "cmbDormitories";
            cmbDormitories.Size = new Size(300, 33);
            cmbDormitories.TabIndex = 0;
            cmbDormitories.SelectedIndexChanged += CmbDormitories_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(135, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 31);
            txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(135, 130);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(300, 31);
            txtAddress.TabIndex = 2;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(135, 180);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(300, 31);
            txtCapacity.TabIndex = 3;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(135, 330);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(300, 40);
            btnSaveChanges.TabIndex = 6;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += BtnSaveChanges_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 7;
            label1.Text = "Dormitories:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 80);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 7;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 130);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 7;
            label3.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 180);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 7;
            label4.Text = "Capacity:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 230);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 7;
            label5.Text = "Manager:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(30, 330);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 40);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // cmbManager
            // 
            cmbManager.FormattingEnabled = true;
            cmbManager.Location = new Point(135, 230);
            cmbManager.Name = "cmbManager";
            cmbManager.Size = new Size(300, 33);
            cmbManager.TabIndex = 9;
            // 
            // EditDormitoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 400);
            Controls.Add(cmbManager);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(cmbDormitories);
            Controls.Add(txtName);
            Controls.Add(txtAddress);
            Controls.Add(txtCapacity);
            Controls.Add(btnSaveChanges);
            Name = "EditDormitoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Dormitory";
            Load += EditDormitoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnBack;
        private ComboBox cmbManager;
    }
}
