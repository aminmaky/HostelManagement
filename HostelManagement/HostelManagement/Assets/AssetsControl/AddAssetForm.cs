using HostelManagement.Blocks;
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
    public partial class AddAssetForm : Form
    {
        public AddAssetForm()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string type = TxtType.Text.Trim();
            string partNumber = CmbPartNumber.SelectedItem?.ToString();
            string status = CmbStatus.SelectedItem?.ToString();
            string room = TxtRoom.Text.Trim();
            string ownerStudent = TxtOwner.Text.Trim();

            if (string.IsNullOrEmpty(type) || string.IsNullOrEmpty(partNumber) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please fill all required fields (Type, Part Number, Status).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string assetNumber = GenerateAssetNumber(partNumber);

            // Equipment newEquipment = new Equipment(type, partNumber, assetNumber, status, room, ownerStudent);

            // Save equipment somewhere (e.g., database or list)
            MessageBox.Show($"New asset added:\nAsset Number: {assetNumber}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear fields
            TxtType.Text = "";
            CmbPartNumber.SelectedIndex = -1;
            CmbStatus.SelectedIndex = -1;
            TxtRoom.Text = "";
            TxtOwner.Text = "";
        }

        private string GenerateAssetNumber(string partNumber)
        {
            string timeComponent = DateTime.Now.Ticks.ToString().Substring(0, 8);
            return timeComponent; // Simple 8-digit based on time
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new AssetManagementForm().Show();
            this.Close();
        }
    }
}
