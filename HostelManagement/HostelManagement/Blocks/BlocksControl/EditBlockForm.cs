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
        private Dormitory dorm;

        public EditBlockForm(Dormitory dormitory)
        {
            InitializeComponent();
            this.dorm = dormitory;
        }


        private void EditBlockForm_Load(object sender, EventArgs e)
        {
            lblDormitory.Text = $"Dormitory: {dorm.Name}";
            cmbBlocks.Items.Clear();

            if (dorm.Blocks != null)
            {
                foreach (var block in dorm.Blocks)
                    cmbBlocks.Items.Add(block);
            }

            cmbBlockManagers.Items.Clear();
            foreach (var manager in DATA.BlockManagers)
            {
                cmbBlockManagers.Items.Add(manager);
            }

        }


        private Block selectedBlock;

        private void CmbBlocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBlock = cmbBlocks.SelectedItem as Block;

            if (selectedBlock != null)
            {
                txtBlockName.Text = selectedBlock.Name;
                numFloors.Value = selectedBlock.FloresCount;
                numRooms.Value = selectedBlock.RoomCount;
                // txt.Text = selectedBlock.supervisor;
            }
            if (selectedBlock.supervisor != null)
            {
                cmbBlockManagers.SelectedItem = selectedBlock.supervisor;
            }
            else
            {
                cmbBlockManagers.SelectedIndex = -1;
            }

        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (selectedBlock == null)
            {
                MessageBox.Show("Please select a block to edit.");
                return;
            }

            if (selectedBlock == null)
            {
                MessageBox.Show("Please select a block to edit.");
                return;
            }

            selectedBlock.Name = txtBlockName.Text;
            selectedBlock.FloresCount = (int)numFloors.Value;
            selectedBlock.RoomCount = (int)numRooms.Value;

            var newManager = cmbBlockManagers.SelectedItem as BlocksManager;

            if (newManager != null && newManager != selectedBlock.supervisor)
            {
                if (selectedBlock.supervisor != null)
                    selectedBlock.supervisor.controledBlock = null;

                selectedBlock.supervisor = newManager;
                newManager.controledBlock = selectedBlock;
            }

            MessageBox.Show("Block updated successfully.");
            this.Close();

        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            new BlockManagementForm().Show();
            this.Close();
        }
    }
}
