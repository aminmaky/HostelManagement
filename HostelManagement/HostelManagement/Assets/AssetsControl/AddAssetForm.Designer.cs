namespace HostelManagement.Assets
{
    partial class AddAssetForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label LblType;
        private Label LblPartNumber;
        private Label LblStatus;
        private Label LblRoom;
        private Label LblOwner;
        private TextBox TxtType;
        private ComboBox CmbPartNumber;
        private ComboBox CmbStatus;
        private TextBox TxtRoom;
        private TextBox TxtOwner;
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
            TxtType = new TextBox();
            LblPartNumber = new Label();
            CmbPartNumber = new ComboBox();
            LblStatus = new Label();
            CmbStatus = new ComboBox();
            LblRoom = new Label();
            TxtRoom = new TextBox();
            LblOwner = new Label();
            TxtOwner = new TextBox();
            BtnSubmit = new Button();
            btnCancel = new Button();
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
            // TxtType
            // 
            TxtType.Location = new Point(250, 27);
            TxtType.Name = "TxtType";
            TxtType.Size = new Size(200, 31);
            TxtType.TabIndex = 1;
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
            CmbPartNumber.Size = new Size(200, 33);
            CmbPartNumber.TabIndex = 3;
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Location = new Point(30, 120);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(64, 25);
            LblStatus.TabIndex = 4;
            LblStatus.Text = "Status:";
            // 
            // CmbStatus
            // 
            CmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbStatus.Items.AddRange(new object[] { "Healthy", "Defective", "Under Repair" });
            CmbStatus.Location = new Point(250, 117);
            CmbStatus.Name = "CmbStatus";
            CmbStatus.Size = new Size(200, 33);
            CmbStatus.TabIndex = 5;
            // 
            // LblRoom
            // 
            LblRoom.AutoSize = true;
            LblRoom.Location = new Point(30, 165);
            LblRoom.Name = "LblRoom";
            LblRoom.Size = new Size(145, 25);
            LblRoom.TabIndex = 6;
            LblRoom.Text = "Room (optional):";
            // 
            // TxtRoom
            // 
            TxtRoom.Location = new Point(250, 162);
            TxtRoom.Name = "TxtRoom";
            TxtRoom.Size = new Size(200, 31);
            TxtRoom.TabIndex = 7;
            // 
            // LblOwner
            // 
            LblOwner.AutoSize = true;
            LblOwner.Location = new Point(30, 210);
            LblOwner.Name = "LblOwner";
            LblOwner.Size = new Size(215, 25);
            LblOwner.TabIndex = 8;
            LblOwner.Text = "Owner Student (optional):";
            // 
            // TxtOwner
            // 
            TxtOwner.Location = new Point(250, 207);
            TxtOwner.Name = "TxtOwner";
            TxtOwner.Size = new Size(200, 31);
            TxtOwner.TabIndex = 9;
            // 
            // BtnSubmit
            // 
            BtnSubmit.Location = new Point(290, 260);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(120, 40);
            BtnSubmit.TabIndex = 10;
            BtnSubmit.Text = "Add Asset";
            BtnSubmit.Click += BtnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(60, 260);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddAssetForm
            // 
            ClientSize = new Size(480, 330);
            Controls.Add(btnCancel);
            Controls.Add(LblType);
            Controls.Add(TxtType);
            Controls.Add(LblPartNumber);
            Controls.Add(CmbPartNumber);
            Controls.Add(LblStatus);
            Controls.Add(CmbStatus);
            Controls.Add(LblRoom);
            Controls.Add(TxtRoom);
            Controls.Add(LblOwner);
            Controls.Add(TxtOwner);
            Controls.Add(BtnSubmit);
            Name = "AddAssetForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Equipment";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnCancel;
    }
}
