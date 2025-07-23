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
        }
        private void BlockManagersForm_Load(object sender, EventArgs e)
        {
            LoadBlockManagers();
        }

        private void LoadBlockManagers()
        {
            lstBlockManagers.Items.Clear();
            foreach (var BlockManager in DATA.BlockManagers)
            {
                lstBlockManagers.Items.Add($"{BlockManager.Firstname} {BlockManager.Lastname} - {BlockManager.controledBlock}");
            }
            // Load from your database or sample data
            // lstBlockManagers.Items.Clear();
            // lstBlockManagers.Items.AddRange(BlockManagerRepository.GetAll().ToArray());
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
                DATA.Students.Remove(selected);
                LoadBlockManagers();
            }
            else
            {
                MessageBox.Show("Please select a block manager to delete.");
            }
        }

        private void btnChangeDormitoryManager_Click(object sender, EventArgs e)
        {
            var selectedBlockManager = lstBlockManagers.SelectedItem as BlocksManager;
            var selectedDormitoryManager = cmbDormitoryManagers.SelectedItem as DormitoryManager;

            if (selectedBlockManager == null || selectedDormitoryManager == null)
            {
                MessageBox.Show("Please select both a block manager and a dormitory manager.");
                return;
            }

            // BlockManagerRepository.UpdateDormitoryManager(selectedBlockManager.Id, selectedDormitoryManager.Id);
            MessageBox.Show("Dormitory manager updated successfully.");
            LoadBlockManagers();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new PersonManagementForm().Show();
            this.Hide();
        }
    }
}
