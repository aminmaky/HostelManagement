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
    public partial class AddBlockManagerForm : Form
    {
        public AddBlockManagerForm()
        {
            InitializeComponent();
            LoadStudents();
            LoadBlocks();
        }

        private void LoadStudents()
        {
            // Load student list from your data source
            cmbStudents.Items.Add("Student A");
            cmbStudents.Items.Add("Student B");
            cmbStudents.Items.Add("Student C");
        }

        private void LoadBlocks()
        {
            // Load block list from your data source
            cmbBlocks.Items.Add("Block 1");
            cmbBlocks.Items.Add("Block 2");
            cmbBlocks.Items.Add("Block 3");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedItem == null || cmbBlocks.SelectedItem == null)
            {
                MessageBox.Show("Please select both a student and a block.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedStudent = cmbStudents.SelectedItem.ToString();
            string selectedBlock = cmbBlocks.SelectedItem.ToString();

            // Save block manager assignment here
            MessageBox.Show($"{selectedStudent} is now assigned as block manager for {selectedBlock}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            new BlockManagersForm().Show();
        }
    }
}
