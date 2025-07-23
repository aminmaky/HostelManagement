namespace HostelManagement.Dormitories
{
    partial class AddDormitoryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private Label lblName;
        private TextBox txtName;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblCapacity;
        private NumericUpDown numCapacity;
        private Label lblManager;
        private ComboBox cmbManager;
        private Button BtnSubmit;
        private Button BtnBack;

        private void InitializeComponent()
        {
            lblName = new Label();
            txtName = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblCapacity = new Label();
            numCapacity = new NumericUpDown();
            lblManager = new Label();
            cmbManager = new ComboBox();
            BtnSubmit = new Button();
            BtnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Location = new Point(30, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(150, 30);
            lblName.TabIndex = 0;
            lblName.Text = "Dormitory Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(200, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 31);
            txtName.TabIndex = 1;
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(30, 70);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(150, 30);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(200, 70);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 31);
            txtAddress.TabIndex = 3;
            // 
            // lblCapacity
            // 
            lblCapacity.Location = new Point(30, 110);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(150, 30);
            lblCapacity.TabIndex = 4;
            lblCapacity.Text = "Total Capacity:";
            // 
            // numCapacity
            // 
            numCapacity.Location = new Point(200, 110);
            numCapacity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(100, 31);
            numCapacity.TabIndex = 5;
            // 
            // lblManager
            // 
            lblManager.Location = new Point(30, 150);
            lblManager.Name = "lblManager";
            lblManager.Size = new Size(150, 30);
            lblManager.TabIndex = 6;
            lblManager.Text = "Manager:";
            // 
            // cmbManager
            // 
            cmbManager.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbManager.Location = new Point(200, 150);
            cmbManager.Name = "cmbManager";
            cmbManager.Size = new Size(250, 33);
            cmbManager.TabIndex = 7;
            // 
            // BtnSubmit
            // 
            BtnSubmit.Location = new Point(80, 200);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(150, 40);
            BtnSubmit.TabIndex = 10;
            BtnSubmit.Text = "Submit";
            BtnSubmit.Click += BtnSubmit_Click;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(250, 200);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(150, 40);
            BtnBack.TabIndex = 11;
            BtnBack.Text = "Back";
            BtnBack.Click += BtnBack_Click;
            // 
            // AddDormitoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 250);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblCapacity);
            Controls.Add(numCapacity);
            Controls.Add(lblManager);
            Controls.Add(cmbManager);
            Controls.Add(BtnSubmit);
            Controls.Add(BtnBack);
            Name = "AddDormitoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Dormitory";
            Load += AddDormitoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
