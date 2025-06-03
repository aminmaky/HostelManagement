using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HostelManagement.Assets
{
    partial class AssetManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private Button BtnAddAsset;
        private Button BtnAssignToRoom;
        private Button BtnAssignToStudent;
        private Button BtnManageTransfers;

        private void InitializeComponent()
        {
            BtnAddAsset = new Button();
            BtnAssignToRoom = new Button();
            BtnAssignToStudent = new Button();
            BtnManageTransfers = new Button();
            BtnManageRepairs = new Button();
            BtnBack = new Button();
            SuspendLayout();
            // 
            // BtnAddAsset
            // 
            BtnAddAsset.Location = new Point(50, 30);
            BtnAddAsset.Name = "BtnAddAsset";
            BtnAddAsset.Size = new Size(300, 45);
            BtnAddAsset.TabIndex = 0;
            BtnAddAsset.Text = "Add New Asset";
            BtnAddAsset.UseVisualStyleBackColor = true;
            BtnAddAsset.Click += BtnAddAsset_Click;
            // 
            // BtnAssignToRoom
            // 
            BtnAssignToRoom.Location = new Point(50, 90);
            BtnAssignToRoom.Name = "BtnAssignToRoom";
            BtnAssignToRoom.Size = new Size(300, 45);
            BtnAssignToRoom.TabIndex = 1;
            BtnAssignToRoom.Text = "Assign Asset to Room";
            BtnAssignToRoom.UseVisualStyleBackColor = true;
            BtnAssignToRoom.Click += BtnAssignToRoom_Click;
            // 
            // BtnAssignToStudent
            // 
            BtnAssignToStudent.Location = new Point(50, 150);
            BtnAssignToStudent.Name = "BtnAssignToStudent";
            BtnAssignToStudent.Size = new Size(300, 45);
            BtnAssignToStudent.TabIndex = 2;
            BtnAssignToStudent.Text = "Assign Asset to Student";
            BtnAssignToStudent.UseVisualStyleBackColor = true;
            BtnAssignToStudent.Click += BtnAssignToStudent_Click;
            // 
            // BtnManageTransfers
            // 
            BtnManageTransfers.Location = new Point(50, 210);
            BtnManageTransfers.Name = "BtnManageTransfers";
            BtnManageTransfers.Size = new Size(300, 45);
            BtnManageTransfers.TabIndex = 3;
            BtnManageTransfers.Text = "Transfers";
            BtnManageTransfers.UseVisualStyleBackColor = true;
            BtnManageTransfers.Click += BtnManageTransfers_Click;
            // 
            // BtnManageRepairs
            // 
            BtnManageRepairs.Location = new Point(50, 270);
            BtnManageRepairs.Name = "BtnManageRepairs";
            BtnManageRepairs.Size = new Size(300, 45);
            BtnManageRepairs.TabIndex = 4;
            BtnManageRepairs.Text = "Repairs";
            BtnManageRepairs.UseVisualStyleBackColor = true;
            BtnManageRepairs.Click += BtnManageRepairs_Click;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(50, 330);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(300, 45);
            BtnBack.TabIndex = 5;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // AssetManagementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 400);
            Controls.Add(BtnBack);
            Controls.Add(BtnManageRepairs);
            Controls.Add(BtnAddAsset);
            Controls.Add(BtnAssignToRoom);
            Controls.Add(BtnAssignToStudent);
            Controls.Add(BtnManageTransfers);
            Name = "AssetManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asset Management";
            Load += AssetManagementForm_Load;
            ResumeLayout(false);
        }

        private Button BtnManageRepairs;
        private Button BtnBack;
    }
}
