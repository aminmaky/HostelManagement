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
        private TextBox txtManager;
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
            txtManager = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblDormitory
            // 
            lblDormitory.AutoSize = true;
            lblDormitory.Location = new Point(20, 20);
            lblDormitory.Text = "Dormitory: ";
            // 
            // lblBlock
            // 
            lblBlock.Location = new Point(20, 60);
            lblBlock.Text = "Select Block:";
            lblBlock.AutoSize = true;
            // 
            // cmbBlocks
            // 
            cmbBlocks.Location = new Point(150, 55);
            cmbBlocks.Size = new Size(250, 33);
            cmbBlocks.SelectedIndexChanged += CmbBlocks_SelectedIndexChanged;
            // 
            // lblName
            // 
            lblName.Location = new Point(20, 100);
            lblName.Text = "Block Name:";
            lblName.AutoSize = true;
            // 
            // txtBlockName
            // 
            txtBlockName.Location = new Point(150, 95);
            txtBlockName.Size = new Size(250, 31);
            // 
            // lblFloors
            // 
            lblFloors.Location = new Point(20, 140);
            lblFloors.Text = "Floors:";
            lblFloors.AutoSize = true;
            // 
            // numFloors
            // 
            numFloors.Location = new Point(150, 135);
            numFloors.Minimum = 1;
            numFloors.Maximum = 100;
            // 
            // lblRooms
            // 
            lblRooms.Location = new Point(20, 180);
            lblRooms.Text = "Rooms:";
            lblRooms.AutoSize = true;
            // 
            // numRooms
            // 
            numRooms.Location = new Point(150, 175);
            numRooms.Minimum = 1;
            numRooms.Maximum = 1000;
            // 
            // lblManager
            // 
            lblManager.Location = new Point(20, 220);
            lblManager.Text = "Manager:";
            lblManager.AutoSize = true;
            // 
            // txtManager
            // 
            txtManager.Location = new Point(150, 215);
            txtManager.Size = new Size(250, 31);
            // 
            // btnSave
            // 
            btnSave.Location = new Point(20, 270);
            btnSave.Text = "Save Changes";
            btnSave.Size = new Size(180, 40);
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(220, 270);
            btnCancel.Text = "Cancel";
            btnCancel.Size = new Size(180, 40);
            btnCancel.Click += BtnCancel_Click;
            // 
            // EditBlockForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 340);
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
            Controls.Add(txtManager);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "EditBlockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Block";
            Load += EditBlockForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
