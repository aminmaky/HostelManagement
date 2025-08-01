using HostelManagement.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HostelManagement.Assets
{
    public partial class RepairAssetForm : Form
    {
        public RepairAssetForm()
        {
            InitializeComponent();
            CmbFilter.Items.Clear();
            CmbFilter.Items.AddRange(new string[] { "All", "Healty", "Defective", "UnderRepair" });
            CmbFilter.SelectedIndex = 0;
            LoadAssets();
        }

        private void LoadAssets(string filter = "All")
        {
            LstAssets.Items.Clear();

            IEnumerable<Tool> assets = DATA.Tools;

            if (filter != "All")
            {
                if (Enum.TryParse(filter, out Status parsedStatus))
                    assets = assets.Where(a => a.Status == parsedStatus);
            }

            foreach (var eq in assets)
            {
                LstAssets.Items.Add($"{eq.PropertyNum} | {eq.Type} | {eq.Status}");
            }
        }

        private string GetSelectedAssetNumber()
        {
            if (LstAssets.SelectedItem == null)
                return null;

            return LstAssets.SelectedItem.ToString().Split('|')[0].Trim();
        }

        private Tool FindSelectedTool()
        {
            var num = GetSelectedAssetNumber();
            return DATA.Tools.FirstOrDefault(t => t.PropertyNum == num);
        }

        private void BtnMarkDamaged_Click(object sender, EventArgs e)
        {
            var tool = FindSelectedTool();
            if (tool == null)
            {
                MessageBox.Show("Please select an asset.");
                return;
            }

            tool.Status = Status.Defective;
            LoadAssets(CmbFilter.SelectedItem?.ToString() ?? "All");
        }

        private void BtnSendToRepair_Click(object sender, EventArgs e)
        {
            var tool = FindSelectedTool();
            if (tool == null)
            {
                MessageBox.Show("Please select an asset.");
                return;
            }

            if (tool.Status != Status.Defective)
            {
                MessageBox.Show("Only defective items can be sent to repair.", "Warning");
                return;
            }

            tool.Status = Status.UnderRepair;
            LoadAssets(CmbFilter.SelectedItem?.ToString() ?? "All");
        }

        private void BtnMarkRepaired_Click(object sender, EventArgs e)
        {
            var tool = FindSelectedTool();
            if (tool == null)
            {
                MessageBox.Show("Please select an asset.");
                return;
            }

            tool.Status = Status.Healty;
            LoadAssets(CmbFilter.SelectedItem?.ToString() ?? "All");
        }

        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAssets(CmbFilter.SelectedItem?.ToString() ?? "All");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            new AssetManagementForm().Show();
            this.Close();
        }
    }
}
