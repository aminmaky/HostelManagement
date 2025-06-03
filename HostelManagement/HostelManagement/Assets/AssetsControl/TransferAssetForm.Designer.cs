using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace HostelManagement.Assets
{
    partial class TransferAssetForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label LblAsset;
        private ComboBox CmbAssets;
        private Label LblTransferType;
        private ComboBox CmbTransferType;
        private Label LblTarget;
        private TextBox TxtTarget;
        private Button BtnTransfer;

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
            LblTransferType = new Label();
            CmbTransferType = new ComboBox();
            LblTarget = new Label();
            TxtTarget = new TextBox();
            BtnTransfer = new Button();
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
            CmbAssets.Location = new Point(180, 27);
            CmbAssets.Name = "CmbAssets";
            CmbAssets.Size = new Size(250, 33);
            CmbAssets.TabIndex = 1;
            // 
            // LblTransferType
            // 
            LblTransferType.AutoSize = true;
            LblTransferType.Location = new Point(30, 80);
            LblTransferType.Name = "LblTransferType";
            LblTransferType.Size = new Size(119, 25);
            LblTransferType.TabIndex = 2;
            LblTransferType.Text = "Transfer Type:";
            // 
            // CmbTransferType
            // 
            CmbTransferType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbTransferType.Items.AddRange(new object[] { "Move between Rooms", "Transfer between Students" });
            CmbTransferType.Location = new Point(180, 77);
            CmbTransferType.Name = "CmbTransferType";
            CmbTransferType.Size = new Size(250, 33);
            CmbTransferType.TabIndex = 3;
            CmbTransferType.SelectedIndexChanged += CmbTransferType_SelectedIndexChanged;
            // 
            // LblTarget
            // 
            LblTarget.AutoSize = true;
            LblTarget.Location = new Point(30, 130);
            LblTarget.Name = "LblTarget";
            LblTarget.Size = new Size(64, 25);
            LblTarget.TabIndex = 4;
            LblTarget.Text = "Target:";
            // 
            // TxtTarget
            // 
            TxtTarget.Location = new Point(180, 127);
            TxtTarget.Name = "TxtTarget";
            TxtTarget.Size = new Size(250, 31);
            TxtTarget.TabIndex = 5;
            // 
            // BtnTransfer
            // 
            BtnTransfer.Location = new Point(280, 180);
            BtnTransfer.Name = "BtnTransfer";
            BtnTransfer.Size = new Size(100, 40);
            BtnTransfer.TabIndex = 6;
            BtnTransfer.Text = "Transfer";
            BtnTransfer.Click += BtnTransfer_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(100, 180);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // TransferAssetForm
            // 
            ClientSize = new Size(480, 250);
            Controls.Add(btnCancel);
            Controls.Add(LblAsset);
            Controls.Add(CmbAssets);
            Controls.Add(LblTransferType);
            Controls.Add(CmbTransferType);
            Controls.Add(LblTarget);
            Controls.Add(TxtTarget);
            Controls.Add(BtnTransfer);
            Name = "TransferAssetForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transfer Equipment";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnCancel;
    }
}
