namespace HostelManagement.Assets
{
    partial class AddAssetForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label LblType;
        private Label LblPartNumber;
        private Label LblStatus;
        private ComboBox CmbPartNumber;
        private ComboBox CmbStatus;
        private Button BtnSubmit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            LblType = new Label();
            LblPartNumber = new Label();
            CmbPartNumber = new ComboBox();
            LblStatus = new Label();
            CmbStatus = new ComboBox();
            BtnSubmit = new Button();
            btnCancel = new Button();
            comboBoxType = new ComboBox();
            txtPropertyNumber = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // LblType
            // 
            LblType.AutoSize = true;
            LblType.Location = new Point(30, 30);
            LblType.Name = "LblType";
            LblType.Size = new Size(53, 25);
            LblType.TabIndex = 0;
            LblType.Text = "Type:";
            // 
            // LblPartNumber
            // 
            LblPartNumber.AutoSize = true;
            LblPartNumber.Location = new Point(30, 75);
            LblPartNumber.Name = "LblPartNumber";
            LblPartNumber.Size = new Size(116, 25);
            LblPartNumber.TabIndex = 2;
            LblPartNumber.Text = "Part Number:";
            // 
            // CmbPartNumber
            // 
            CmbPartNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbPartNumber.Items.AddRange(new object[] { "001", "002", "003", "004", "005" });
            CmbPartNumber.Location = new Point(250, 72);
            CmbPartNumber.Name = "CmbPartNumber";
            CmbPartNumber.Size = new Size(201, 33);
            CmbPartNumber.TabIndex = 3;
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Location = new Point(31, 156);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(64, 25);
            LblStatus.TabIndex = 4;
            LblStatus.Text = "Status:";
            // 
            // CmbStatus
            // 
            CmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbStatus.Items.AddRange(new object[] { "Healthy", "Defective", "Under Repair" });
            CmbStatus.Location = new Point(251, 153);
            CmbStatus.Name = "CmbStatus";
            CmbStatus.Size = new Size(200, 33);
            CmbStatus.TabIndex = 5;
            // 
            // BtnSubmit
            // 
            BtnSubmit.Location = new Point(295, 206);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(120, 40);
            BtnSubmit.TabIndex = 10;
            BtnSubmit.Text = "Add Asset";
            BtnSubmit.Click += BtnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(65, 206);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(250, 33);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(200, 33);
            comboBoxType.TabIndex = 12;
            // 
            // txtPropertyNumber
            // 
            txtPropertyNumber.Location = new Point(251, 111);
            txtPropertyNumber.Name = "txtPropertyNumber";
            txtPropertyNumber.Size = new Size(200, 31);
            txtPropertyNumber.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 117);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 14;
            label1.Text = "Property Number:";
            // 
            // AddAssetForm
            // 
            ClientSize = new Size(480, 264);
            Controls.Add(label1);
            Controls.Add(txtPropertyNumber);
            Controls.Add(comboBoxType);
            Controls.Add(btnCancel);
            Controls.Add(LblType);
            Controls.Add(LblPartNumber);
            Controls.Add(CmbPartNumber);
            Controls.Add(LblStatus);
            Controls.Add(CmbStatus);
            Controls.Add(BtnSubmit);
            Name = "AddAssetForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AddAssetForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnCancel;
        private ComboBox comboBoxType;
        private TextBox txtPropertyNumber;
        private Label label1;
    }
}
