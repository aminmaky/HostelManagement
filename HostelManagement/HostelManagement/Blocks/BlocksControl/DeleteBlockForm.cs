using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement.Blocks
{
    public partial class DeleteBlockForm : Form
    {
        private string dormitoryName;

        public DeleteBlockForm(string dormitoryName)
        {
            InitializeComponent();
            this.dormitoryName = dormitoryName;
        }

        private void DeleteBlockForm_Load(object sender, EventArgs e)
        {
            lblDormitory.Text = $"Dormitory: {dormitoryName}";

            // Mock: Load block list from DB or data
            lstBlocks.Items.Add("Block A");
            lstBlocks.Items.Add("Block B");
            lstBlocks.Items.Add("Block C");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lstBlocks.SelectedItem == null)
            {
                MessageBox.Show("Please select a block to delete.");
                return;
            }

            string selectedBlock = lstBlocks.SelectedItem.ToString();

            var result = MessageBox.Show($"Are you sure you want to delete '{selectedBlock}'?",
                                         "Confirm Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Perform deletion from database or list here...

                MessageBox.Show("Block deleted successfully.");
                lstBlocks.Items.Remove(selectedBlock);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            new BlockManagementForm().Show();
            this.Close();
        }
    }
}
