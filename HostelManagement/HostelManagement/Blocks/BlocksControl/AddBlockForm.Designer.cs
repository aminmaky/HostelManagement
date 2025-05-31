namespace HostelManagement.Blocks
{
    partial class AddBlockForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private Label lblDormitoryName;
        private TextBox txtBlockName;
        private TextBox txtFloors;
        private TextBox txtRooms;
        private ComboBox cmbSupervisor;
        private Button btnAdd;
        private Button btnCancel;
        private Label label1;

        private void InitializeComponent()
        {
            lblDormitoryName = new Label();
            txtBlockName = new TextBox();
            txtFloors = new TextBox();
            txtRooms = new TextBox();
            cmbSupervisor = new ComboBox();
            btnAdd = new Button();
            btnCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblDormitoryName
            // 
            lblDormitoryName.AutoSize = true;
            lblDormitoryName.Location = new Point(20, 20);
            lblDormitoryName.Name = "lblDormitoryName";
            lblDormitoryName.Size = new Size(103, 25);
            lblDormitoryName.TabIndex = 0;
            lblDormitoryName.Text = "Dormitory: ";
            // 
            // txtBlockName
            // 
            txtBlockName.Location = new Point(20, 60);
            txtBlockName.Name = "txtBlockName";
            txtBlockName.PlaceholderText = "Block Name";
            txtBlockName.Size = new Size(350, 31);
            txtBlockName.TabIndex = 1;
            // 
            // txtFloors
            // 
            txtFloors.Location = new Point(20, 100);
            txtFloors.Name = "txtFloors";
            txtFloors.PlaceholderText = "Number of Floors";
            txtFloors.Size = new Size(350, 31);
            txtFloors.TabIndex = 2;
            // 
            // txtRooms
            // 
            txtRooms.Location = new Point(20, 140);
            txtRooms.Name = "txtRooms";
            txtRooms.PlaceholderText = "Number of Rooms";
            txtRooms.Size = new Size(350, 31);
            txtRooms.TabIndex = 3;
            // 
            // cmbSupervisor
            // 
            cmbSupervisor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupervisor.Location = new Point(120, 180);
            cmbSupervisor.Name = "cmbSupervisor";
            cmbSupervisor.Size = new Size(250, 33);
            cmbSupervisor.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 230);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(170, 40);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(200, 230);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 40);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.Click += BtnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 183);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 7;
            label1.Text = "Supervisor:";
            // 
            // AddBlockForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 300);
            Controls.Add(label1);
            Controls.Add(lblDormitoryName);
            Controls.Add(txtBlockName);
            Controls.Add(txtFloors);
            Controls.Add(txtRooms);
            Controls.Add(cmbSupervisor);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Name = "AddBlockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Block";
            Load += AddBlockForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
