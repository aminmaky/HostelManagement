using HostelManagement.Blocks;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HostelManagement.Assets
{
    public partial class AddAssetForm : Form
    {
        public AddAssetForm()
        {
            InitializeComponent();
        }

        private void AddAssetForm_Load(object sender, EventArgs e)
        {
            comboBoxType.Items.Clear();
            CmbStatus.Items.Clear();
            CmbPartNumber.Items.Clear();
            comboBoxType.DataSource = Enum.GetNames(typeof(Asset));
            CmbStatus.DataSource = Enum.GetNames(typeof(Status));
            CmbPartNumber.Items.AddRange(new string[] { "001", "002", "003", "004", "005" });
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string typeText = comboBoxType.SelectedItem?.ToString();
            string partNumber = CmbPartNumber.SelectedItem?.ToString();
            string propertyNumber = txtPropertyNumber.Text.Trim();
            string statusText = CmbStatus.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(typeText) || string.IsNullOrEmpty(partNumber) ||
                string.IsNullOrEmpty(propertyNumber) || string.IsNullOrEmpty(statusText))
            {
                MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Enum.TryParse(typeText, out Asset typeEnum))
            {
                MessageBox.Show("Invalid asset type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Enum.TryParse(statusText, out Status statusEnum))
            {
                MessageBox.Show("Invalid status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (propertyNumber.Length != 8 || !propertyNumber.All(char.IsDigit))
            {
                MessageBox.Show("Property Number must be exactly 8 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DATA.Tools.Any(t => t.PropertyNum == propertyNumber))
            {
                MessageBox.Show("This Property Number already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tool newTool = new Tool(
                typeEnum,
                partNumber,
                propertyNumber,
                statusEnum
            );

            DATA.Tools.Add(newTool);

            MessageBox.Show($"New asset added:\nAsset Number: {propertyNumber}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset form
            comboBoxType.SelectedIndex = 0;
            txtPropertyNumber.Text = "";
            CmbPartNumber.SelectedIndex = 0;
            CmbStatus.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new AssetManagementForm().Show();
            this.Close();
        }
    }
}
