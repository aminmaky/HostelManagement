namespace HostelManagement.Assets
{
    partial class RepairAssetForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label LblTitle;
        private ComboBox CmbFilter;
        private ListBox LstAssets;
        private Button BtnMarkDamaged;
        private Button BtnSendToRepair;
        private Button BtnMarkRepaired;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            LblTitle = new Label();
            CmbFilter = new ComboBox();
            LstAssets = new ListBox();
            BtnMarkDamaged = new Button();
            BtnSendToRepair = new Button();
            BtnMarkRepaired = new Button();
            BtnCancel = new Button();
            SuspendLayout();
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.Location = new Point(20, 20);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(132, 25);
            LblTitle.TabIndex = 0;
            LblTitle.Text = "Filter by Status:";
            // 
            // CmbFilter
            // 
            CmbFilter.Items.AddRange(new object[] { "All", "Healthy", "Defective", "Under repair" });
            CmbFilter.Location = new Point(174, 17);
            CmbFilter.Name = "CmbFilter";
            CmbFilter.Size = new Size(200, 33);
            CmbFilter.TabIndex = 1;
            CmbFilter.SelectedIndexChanged += CmbFilter_SelectedIndexChanged;
            // 
            // LstAssets
            // 
            LstAssets.ItemHeight = 25;
            LstAssets.Location = new Point(20, 60);
            LstAssets.Name = "LstAssets";
            LstAssets.Size = new Size(614, 179);
            LstAssets.TabIndex = 2;
            // 
            // BtnMarkDamaged
            // 
            BtnMarkDamaged.Location = new Point(22, 260);
            BtnMarkDamaged.Name = "BtnMarkDamaged";
            BtnMarkDamaged.Size = new Size(200, 40);
            BtnMarkDamaged.TabIndex = 3;
            BtnMarkDamaged.Text = "Mark as Damaged";
            BtnMarkDamaged.Click += BtnMarkDamaged_Click;
            // 
            // BtnSendToRepair
            // 
            BtnSendToRepair.Location = new Point(228, 260);
            BtnSendToRepair.Name = "BtnSendToRepair";
            BtnSendToRepair.Size = new Size(200, 40);
            BtnSendToRepair.TabIndex = 4;
            BtnSendToRepair.Text = "Send to Repair";
            BtnSendToRepair.Click += BtnSendToRepair_Click;
            // 
            // BtnMarkRepaired
            // 
            BtnMarkRepaired.Location = new Point(434, 260);
            BtnMarkRepaired.Name = "BtnMarkRepaired";
            BtnMarkRepaired.Size = new Size(200, 40);
            BtnMarkRepaired.TabIndex = 5;
            BtnMarkRepaired.Text = "Mark Repaired";
            BtnMarkRepaired.Click += BtnMarkRepaired_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(22, 314);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(112, 34);
            BtnCancel.TabIndex = 6;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // RepairAssetForm
            // 
            ClientSize = new Size(655, 360);
            Controls.Add(BtnCancel);
            Controls.Add(LblTitle);
            Controls.Add(CmbFilter);
            Controls.Add(LstAssets);
            Controls.Add(BtnMarkDamaged);
            Controls.Add(BtnSendToRepair);
            Controls.Add(BtnMarkRepaired);
            Name = "RepairAssetForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Repair Asset Management";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button BtnCancel;
    }
}
