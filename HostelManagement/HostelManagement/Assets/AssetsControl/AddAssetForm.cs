using HostelManagement.Blocks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            comboBoxType.DataSource = Enum.GetNames(typeof(Asset));
        }


        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string typeText = comboBoxType.SelectedItem?.ToString(); 
            string partNumber = CmbPartNumber.SelectedItem?.ToString();
            string PropertyNumber = txtPropertyNumber.Text.Trim();
            string statusText = CmbStatus.SelectedItem?.ToString();
            //string roomText = TxtRoom.Text.Trim();
            //string ownerName = TxtOwner.Text.Trim();

            if (string.IsNullOrEmpty(typeText) || string.IsNullOrEmpty(partNumber) || string.IsNullOrEmpty(PropertyNumber) || string.IsNullOrEmpty(statusText))
            {
                MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Enum.TryParse(statusText, out status statusEnum))
            {
                MessageBox.Show("Invalid status type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (PropertyNumber.Length != 8 || !PropertyNumber.All(char.IsDigit))
            {
                MessageBox.Show("Property Number must be exactly 8 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Asset typeEnum = typeText as Asset;

            Tool newTool = new Tool(
                typeEnum,
                partNumber,
                PropertyNumber,
                statusEnum // ,
                           // roomNum,
                           // ownerName
            );

            DATA.Tools.Add(newTool);

            MessageBox.Show($"New asset added:\nAsset Number: {PropertyNumber}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear fields
            comboBoxType.SelectedIndex = -1;
            txtPropertyNumber.Text = "";
            CmbPartNumber.SelectedIndex = -1;
            CmbStatus.SelectedIndex = -1;
            // TxtRoom.Text = "";
            // TxtOwner.Text = "";
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            new AssetManagementForm().Show();
            this.Close();
        }
    }
}
