using HostelManagement.Persons.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement.Persons.BlockManagers
{
    public partial class BlockManagersForm : Form
    {
        public BlockManagersForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void BlockManagersForm_Load(object sender, EventArgs e)
        {
            LoadBlockManagers();
        }

        private void LoadBlockManagers()
        {
            lstBlockManagers.Items.Clear();

            foreach (var blockManager in DATA.BlockManagers)
            {
                string blockName = blockManager.ControledBlock != null ? blockManager.ControledBlock.Name : "Unassigned";
                lstBlockManagers.Items.Add(blockManager);
            }

            // Populate Dormitory Managers dropdown (once)
            cmbDormitoryManagers.Items.Clear();
            cmbDormitoryManagers.Items.AddRange(DATA.BlockManagers.ToArray());
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddBlockManagerForm().Show();
            this.Hide();
            //var addForm = new AddBlockManagerForm();
            //if (addForm.ShowDialog() == DialogResult.OK)
            //{
            //    LoadBlockManagers();
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = lstBlockManagers.SelectedItem as BlocksManager;

            if (selected != null)
            {
                DATA.BlockManagers.Remove(selected);
                if (selected.ControledBlock != null)
                    selected.ControledBlock.Supervisor = null;

                LoadBlockManagers();
            }
            else
            {
                MessageBox.Show("Please select a block manager to delete.");
            }
        }


        private void btnChangeBlockManager_Click(object sender, EventArgs e)
        {
            var selectedBlockManager = lstBlockManagers.SelectedItem as BlocksManager;
            var newBlockManager = cmbDormitoryManagers.SelectedItem as BlocksManager;

            if (selectedBlockManager == null || newBlockManager == null)
            {
                MessageBox.Show("Please select both block managers.");
                return;
            }

            if (selectedBlockManager.ControledBlock == null || newBlockManager.ControledBlock == null)
            {
                MessageBox.Show("Each manager must be assigned to a block before swapping.");
                return;
            }

            // --- Swap Logic ---
            var tempBlock = selectedBlockManager.ControledBlock;

            selectedBlockManager.ControledBlock = newBlockManager.ControledBlock;
            newBlockManager.ControledBlock = tempBlock;

            selectedBlockManager.ControledBlock.Supervisor = selectedBlockManager;
            newBlockManager.ControledBlock.Supervisor = newBlockManager;

            MessageBox.Show("Block managers swapped successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadBlockManagers();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            new PersonManagementForm().Show();
            this.Hide();
        }
    }
}
