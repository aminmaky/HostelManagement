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
    public partial class TransferAssetForm : Form
    {
        public TransferAssetForm()
        {
            InitializeComponent();
            LoadAssets();
        }

        private void LoadAssets()
        {
            CmbAssets.Items.Clear();
            //foreach (var eq in AssetStorage.AllEquipments)
            //{
            //    CmbAssets.Items.Add($"{eq.AssetNumber} - {eq.Type}");
            //}
        }

        private void CmbTransferType_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtTarget.Text = "";
            LblTarget.Text = CmbTransferType.SelectedIndex == 0 ? "New Room Number:" : "New Student:";
        }

        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            /*
            if (CmbAssets.SelectedItem == null || CmbTransferType.SelectedItem == null || string.IsNullOrWhiteSpace(TxtTarget.Text))
            {
                MessageBox.Show("Please complete all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string assetNumber = CmbAssets.SelectedItem.ToString().Split('-')[0].Trim();
            var equipment = AssetStorage.AllEquipments.Find(e => e.AssetNumber == assetNumber);

            if (equipment == null)
            {
                MessageBox.Show("Equipment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CmbTransferType.SelectedIndex == 0) // Room transfer
            {
                equipment.Room = TxtTarget.Text.Trim();
                MessageBox.Show("Asset moved to new room.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Student transfer
            {
                if (IsPersonal(equipment.Type))
                {
                    equipment.Student = TxtTarget.Text.Trim();
                    MessageBox.Show("Asset transferred to new student.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Only personal items can be assigned to students.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            CmbAssets.SelectedIndex = -1;
            CmbTransferType.SelectedIndex = -1;
            TxtTarget.Text = "";
            LblTarget.Text = "Target:";
            */
        }

        private bool IsPersonal(string type)
        {
            return type == "تخت" || type == "میز" || type == "صندلی" || type == "کمد";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new AssetManagementForm().Show();
            this.Close();
        }
    }
}
