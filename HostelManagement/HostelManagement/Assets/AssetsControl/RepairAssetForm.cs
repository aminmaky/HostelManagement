using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement.Assets
{
    public partial class RepairAssetForm : Form
    {
        public RepairAssetForm()
        {
            InitializeComponent();
            LoadAssets();
        }

        private void LoadAssets(string filter = "All")
        {
            /*
            LstAssets.Items.Clear();
            var assets = AssetStorage.AllEquipments;

            if (filter != "All")
                assets = assets.Where(a => a.Status == filter).ToList();

            foreach (var eq in assets)
            {
                LstAssets.Items.Add($"{eq.AssetNumber} | {eq.Type} | {eq.Status}");
            }
            */
        }

        private string GetSelectedAssetNumber()
        {
            if (LstAssets.SelectedItem == null)
                return null;

            return LstAssets.SelectedItem.ToString().Split('|')[0].Trim();
        }
        /*
        private Equipment FindSelectedEquipment()
        {
            var num = GetSelectedAssetNumber();
            return AssetStorage.AllEquipments.FirstOrDefault(e => e.AssetNumber == num);
        }
        */
        private void BtnMarkDamaged_Click(object sender, EventArgs e)
        {
            /*
            var eq = FindSelectedEquipment();
            if (eq == null) return;

            eq.Status = "معیوب";
            LoadAssets(CmbFilter.SelectedItem?.ToString() ?? "All");
            */
        }

        private void BtnSendToRepair_Click(object sender, EventArgs e)
        {
            /*
            var eq = FindSelectedEquipment();
            if (eq == null || eq.Status != "معیوب")
            {
                MessageBox.Show("Only damaged items can be sent to repair.", "Warning");
                return;
            }

            eq.Status = "در حال تعمیر";
            LoadAssets(CmbFilter.SelectedItem?.ToString() ?? "All");
            */
        }

        private void BtnMarkRepaired_Click(object sender, EventArgs e)
        {
            /*
            var eq = FindSelectedEquipment();
            if (eq == null) return;

            eq.Status = "سالم";
            LoadAssets(CmbFilter.SelectedItem?.ToString() ?? "All");
            */
        }

        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAssets(CmbFilter.SelectedItem?.ToString() ?? "All");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            new AssetManagementForm().Show();
            this.Hide();
        }
    }
}
