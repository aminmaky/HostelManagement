using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace HostelManagement.Assets
{
    partial class AssignAssetToRoomForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label LblAsset;
        private ComboBox CmbAssets;
        private Button BtnAssign;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            LblAsset = new Label();
            CmbAssets = new ComboBox();
            BtnAssign = new Button();
            btnCancel = new Button();
            cmbRoom = new ComboBox();
            lblDormitory = new Label();
            cmbDormitory = new ComboBox();
            lblBlock = new Label();
            cmbBlock = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // LblAsset
            // 
            LblAsset.AutoSize = true;
            LblAsset.Location = new Point(30, 30);
            LblAsset.Name = "LblAsset";
            LblAsset.Size = new Size(110, 25);
            LblAsset.TabIndex = 0;
            LblAsset.Text = "Select Asset:";
            // 
            // CmbAssets
            // 
            CmbAssets.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbAssets.Location = new Point(220, 30);
            CmbAssets.Name = "CmbAssets";
            CmbAssets.Size = new Size(250, 33);
            CmbAssets.TabIndex = 1;
            // 
            // BtnAssign
            // 
            BtnAssign.Location = new Point(325, 238);
            BtnAssign.Name = "BtnAssign";
            BtnAssign.Size = new Size(100, 40);
            BtnAssign.TabIndex = 4;
            BtnAssign.Text = "Assign";
            BtnAssign.Click += BtnAssign_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(50, 238);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbRoom
            // 
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(220, 181);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(249, 33);
            cmbRoom.TabIndex = 16;
            // 
            // lblDormitory
            // 
            lblDormitory.AutoSize = true;
            lblDormitory.Location = new Point(30, 84);
            lblDormitory.Margin = new Padding(4, 0, 4, 0);
            lblDormitory.Name = "lblDormitory";
            lblDormitory.Size = new Size(94, 25);
            lblDormitory.TabIndex = 11;
            lblDormitory.Text = "Dormitory";
            // 
            // cmbDormitory
            // 
            cmbDormitory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDormitory.Location = new Point(220, 81);
            cmbDormitory.Margin = new Padding(4);
            cmbDormitory.Name = "cmbDormitory";
            cmbDormitory.Size = new Size(249, 33);
            cmbDormitory.TabIndex = 12;
            // cmbDormitory.SelectedIndexChanged += cmbDormitory_SelectedIndexChanged;
            // 
            // lblBlock
            // 
            lblBlock.AutoSize = true;
            lblBlock.Location = new Point(30, 134);
            lblBlock.Margin = new Padding(4, 0, 4, 0);
            lblBlock.Name = "lblBlock";
            lblBlock.Size = new Size(54, 25);
            lblBlock.TabIndex = 13;
            lblBlock.Text = "Block";
            // 
            // cmbBlock
            // 
            cmbBlock.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBlock.Location = new Point(220, 131);
            cmbBlock.Margin = new Padding(4);
            cmbBlock.Name = "cmbBlock";
            cmbBlock.Size = new Size(249, 33);
            cmbBlock.TabIndex = 14;
            cmbBlock.SelectedIndexChanged += cmbBlock_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 184);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 15;
            label1.Text = "Room";
            // 
            // AssignAssetToRoomForm
            // 
            ClientSize = new Size(500, 300);
            Controls.Add(cmbRoom);
            Controls.Add(lblDormitory);
            Controls.Add(cmbDormitory);
            Controls.Add(lblBlock);
            Controls.Add(cmbBlock);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(LblAsset);
            Controls.Add(CmbAssets);
            Controls.Add(BtnAssign);
            Name = "AssignAssetToRoomForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assign Asset to Room";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnCancel;
        private ComboBox cmbRoom;
        private Label lblDormitory;
        private ComboBox cmbDormitory;
        private Label lblBlock;
        private ComboBox cmbBlock;
        private Label label1;
    }
}
