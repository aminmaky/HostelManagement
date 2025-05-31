using HostelManagement.Dormitories;
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
    public partial class AddBlockForm : Form
    {
        private string dormitoryName;

        public AddBlockForm(string dormitoryName)
        {
            InitializeComponent();
            this.dormitoryName = dormitoryName;
        }

        private void AddBlockForm_Load(object sender, EventArgs e)
        {
            lblDormitoryName.Text = $"Dormitory: {dormitoryName}";

            // You can load available supervisors here
            cmbSupervisor.Items.Add("Supervisor A");
            cmbSupervisor.Items.Add("Supervisor B");
            cmbSupervisor.Items.Add("Supervisor C");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string blockName = txtBlockName.Text.Trim();
            int numFloors, numRooms;

            if (string.IsNullOrWhiteSpace(blockName) ||
                !int.TryParse(txtFloors.Text, out numFloors) ||
                !int.TryParse(txtRooms.Text, out numRooms) ||
                cmbSupervisor.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields correctly.");
                return;
            }

            // Save to DB or data structure here...

            MessageBox.Show("Block added successfully!");
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            new BlockManagementForm().Show();
            this.Close();
        }
    }
}
