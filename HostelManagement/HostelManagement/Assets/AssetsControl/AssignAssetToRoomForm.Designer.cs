using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace HostelManagement.Assets
{
    partial class AssignAssetToRoomForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label LblAsset;
        private ComboBox CmbAssets;
        private Label LblRoom;
        private TextBox TxtRoom;
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
            LblRoom = new Label();
            TxtRoom = new TextBox();
            BtnAssign = new Button();
            btnCancel = new Button();
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
            // LblRoom
            // 
            LblRoom.AutoSize = true;
            LblRoom.Location = new Point(30, 80);
            LblRoom.Name = "LblRoom";
            LblRoom.Size = new Size(179, 25);
            LblRoom.TabIndex = 2;
            LblRoom.Text = "Enter Room Number:";
            // 
            // TxtRoom
            // 
            TxtRoom.Location = new Point(270, 80);
            TxtRoom.Name = "TxtRoom";
            TxtRoom.Size = new Size(200, 31);
            TxtRoom.TabIndex = 3;
            // 
            // BtnAssign
            // 
            BtnAssign.Location = new Point(340, 130);
            BtnAssign.Name = "BtnAssign";
            BtnAssign.Size = new Size(100, 40);
            BtnAssign.TabIndex = 4;
            BtnAssign.Text = "Assign";
            BtnAssign.Click += BtnAssign_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(65, 130);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AssignAssetToRoomForm
            // 
            ClientSize = new Size(500, 200);
            Controls.Add(btnCancel);
            Controls.Add(LblAsset);
            Controls.Add(CmbAssets);
            Controls.Add(LblRoom);
            Controls.Add(TxtRoom);
            Controls.Add(BtnAssign);
            Name = "AssignAssetToRoomForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assign Asset to Room";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnCancel;
    }
}
