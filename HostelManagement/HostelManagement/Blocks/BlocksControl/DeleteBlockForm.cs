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
        private Dormitory dorm;

        public DeleteBlockForm(Dormitory dormitory)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.dorm = dormitory;
        }

        private void DeleteBlockForm_Load(object sender, EventArgs e)
        {
            lblDormitory.Text = $"Dormitory: {dorm.Name}";

            lstBlocks.Items.Clear();
            if (dorm.Blocks != null)
            {
                foreach (var block in dorm.Blocks)
                {
                    lstBlocks.Items.Add(block); 
                }
            }
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lstBlocks.SelectedItem == null)
            {
                MessageBox.Show("Please select a block to delete.");
                return;
            }

            Block selectedBlock = lstBlocks.SelectedItem as Block;
            if (selectedBlock == null) return;

            var result = MessageBox.Show($"Are you sure you want to delete '{selectedBlock.Name}'?",
                                         "Confirm Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                dorm.Blocks.Remove(selectedBlock);
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
