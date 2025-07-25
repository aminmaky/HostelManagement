namespace HostelManagement.Blocks
{
    partial class EditBlockForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private Label lblDormitory;
        private ComboBox cmbBlocks;
        private TextBox txtBlockName;
        private NumericUpDown numFloors;
        private NumericUpDown numRooms;
        private TextBox txt;
        private Button btnSave;
        private Button btnCancel;
        private Label lblBlock;
        private Label lblName;
        private Label lblFloors;
        private Label lblRooms;
        private Label lblManager;

        private void InitializeComponent()
        {
            lblDormitory = new Label();
            lblBlock = new Label();
            cmbBlocks = new ComboBox();
            lblName = new Label();
            txtBlockName = new TextBox();
            lblFloors = new Label();
            numFloors = new NumericUpDown();
            lblRooms = new Label();
            numRooms = new NumericUpDown();
            lblManager = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            cmbBlockManagers = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numFloors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRooms).BeginInit();
            SuspendLayout();
            // 
            // lblDormitory
            // 
            lblDormitory.AutoSize = true;
            lblDormitory.Location = new Point(20, 20);
            lblDormitory.Name = "lblDormitory";
            lblDormitory.Size = new Size(103, 25);
            lblDormitory.TabIndex = 0;
            lblDormitory.Text = "Dormitory: ";
            // 
            // lblBlock
            // 
            lblBlock.AutoSize = true;
            lblBlock.Location = new Point(20, 60);
            lblBlock.Name = "lblBlock";
            lblBlock.Size = new Size(109, 25);
            lblBlock.TabIndex = 1;
            lblBlock.Text = "Select Block:";
            // 
            // cmbBlocks
            // 
            cmbBlocks.Location = new Point(150, 55);
            cmbBlocks.Name = "cmbBlocks";
            cmbBlocks.Size = new Size(250, 33);
            cmbBlocks.TabIndex = 2;
            cmbBlocks.SelectedIndexChanged += CmbBlocks_SelectedIndexChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(110, 25);
            lblName.TabIndex = 3;
            lblName.Text = "Block Name:";
            // 
            // txtBlockName
            // 
            txtBlockName.Location = new Point(150, 95);
            txtBlockName.Name = "txtBlockName";
            txtBlockName.Size = new Size(250, 31);
            txtBlockName.TabIndex = 4;
            // 
            // lblFloors
            // 
            lblFloors.AutoSize = true;
            lblFloors.Location = new Point(20, 140);
            lblFloors.Name = "lblFloors";
            lblFloors.Size = new Size(65, 25);
            lblFloors.TabIndex = 5;
            lblFloors.Text = "Floors:";
            // 
            // numFloors
            // 
            numFloors.Location = new Point(150, 135);
            numFloors.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numFloors.Name = "numFloors";
            numFloors.Size = new Size(120, 31);
            numFloors.TabIndex = 6;
            numFloors.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblRooms
            // 
            lblRooms.AutoSize = true;
            lblRooms.Location = new Point(20, 180);
            lblRooms.Name = "lblRooms";
            lblRooms.Size = new Size(72, 25);
            lblRooms.TabIndex = 7;
            lblRooms.Text = "Rooms:";
            // 
            // numRooms
            // 
            numRooms.Location = new Point(150, 175);
            numRooms.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numRooms.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRooms.Name = "numRooms";
            numRooms.Size = new Size(120, 31);
            numRooms.TabIndex = 8;
            numRooms.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblManager
            // 
            lblManager.AutoSize = true;
            lblManager.Location = new Point(20, 220);
            lblManager.Name = "lblManager";
            lblManager.Size = new Size(86, 25);
            lblManager.TabIndex = 9;
            lblManager.Text = "Manager:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(20, 270);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 40);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save Changes";
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(220, 270);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(180, 40);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.Click += BtnCancel_Click;
            // 
            // cmbBlockManagers
            // 
            cmbBlockManagers.FormattingEnabled = true;
            cmbBlockManagers.Location = new Point(150, 217);
            cmbBlockManagers.Name = "cmbBlockManagers";
            cmbBlockManagers.Size = new Size(250, 33);
            cmbBlockManagers.TabIndex = 13;
            // 
            // EditBlockForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 340);
            Controls.Add(cmbBlockManagers);
            Controls.Add(lblDormitory);
            Controls.Add(lblBlock);
            Controls.Add(cmbBlocks);
            Controls.Add(lblName);
            Controls.Add(txtBlockName);
            Controls.Add(lblFloors);
            Controls.Add(numFloors);
            Controls.Add(lblRooms);
            Controls.Add(numRooms);
            Controls.Add(lblManager);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "EditBlockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Block";
            Load += EditBlockForm_Load;
            ((System.ComponentModel.ISupportInitialize)numFloors).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBox cmbBlockManagers;
    }
}
