using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;
using HostelManagement.Blocks;

namespace HostelManagement.Assets
{
    public partial class AssignAssetToRoomForm : Form
    {
        public AssignAssetToRoomForm()
        {
            InitializeComponent();
            LoadAssetList();
        }

        private void LoadAssetList()
        {
            // فرض: تجهیزات از یک منبع داده مثل لیست یا دیتابیس خوانده می‌شوند.
            CmbAssets.Items.Clear();

            //foreach (var equipment in AssetStorage.AllEquipments)
            //{
            //    CmbAssets.Items.Add($"{equipment.AssetNumber} - {equipment.Type}");
            //}
        }

        private void BtnAssign_Click(object sender, EventArgs e)
        {
            if (CmbAssets.SelectedItem == null || string.IsNullOrWhiteSpace(TxtRoom.Text))
            {
                MessageBox.Show("Please select an asset and enter a room number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedAssetStr = CmbAssets.SelectedItem.ToString();
            string assetNumber = selectedAssetStr.Split('-')[0].Trim();
            string newRoom = TxtRoom.Text.Trim();

            // Equipment eq = AssetStorage.AllEquipments.Find(e => e.AssetNumber == assetNumber);

            //if (eq != null)
            //{
            //    eq.Room = newRoom;
            //    MessageBox.Show($"Asset {eq.AssetNumber} assigned to Room {newRoom}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Asset not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            TxtRoom.Text = "";
            CmbAssets.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new AssetManagementForm().Show();
            this.Close();
        }
    }
}
