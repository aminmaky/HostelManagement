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
    public partial class EditBlockForm : Form
    {
        private string dormitoryName;

        public EditBlockForm(Dormitory dormitoryName)
        {
            InitializeComponent();
            // this.dormitoryName = dormitoryName;
        }

        private void EditBlockForm_Load(object sender, EventArgs e)
        {
            lblDormitory.Text = $"Dormitory: {dormitoryName}";

            // Mock: load existing blocks (should be fetched from DB)
            cmbBlocks.Items.Add("Block A");
            cmbBlocks.Items.Add("Block B");
            cmbBlocks.Items.Add("Block C");
        }

        private void CmbBlocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load block details for editing - Mock values
            string selected = cmbBlocks.SelectedItem.ToString();
            txtBlockName.Text = selected;
            numFloors.Value = 3;
            numRooms.Value = 30;
            txtManager.Text = "John Doe";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (cmbBlocks.SelectedItem == null)
            {
                MessageBox.Show("Please select a block to edit.");
                return;
            }

            string newName = txtBlockName.Text;
            int floors = (int)numFloors.Value;
            int rooms = (int)numRooms.Value;
            string manager = txtManager.Text;

            // Save logic here...

            MessageBox.Show("Block updated successfully.");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            new BlockManagementForm().Show();
            this.Close();
        }
    }
}
