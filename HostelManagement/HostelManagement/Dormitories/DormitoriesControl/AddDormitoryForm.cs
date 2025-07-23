using HostelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement.Dormitories
{
    public partial class AddDormitoryForm : Form
    {
        public AddDormitoryForm()
        {
            InitializeComponent();
        }

        private void AddDormitoryForm_Load(object sender, EventArgs e)
        {
            cmbManager.DataSource = DATA.DormitoryManagers;

            cmbManager.SelectedIndex = -1;
            // Optional: Load data such as list of dorm managers or blocks
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string address = txtAddress.Text.Trim();
            int capacity = (int)numCapacity.Value;
            DormitoryManager manager = cmbManager.SelectedItem as DormitoryManager;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || capacity <= 0 || manager == null)
            {
                MessageBox.Show("Please fill out all fields and select a manager.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Dormitory NewDormitory = new Dormitory(name, address, capacity,
            manager/*, List<Block> selectedBlocks*/);

            DATA.Dormitories.Add(NewDormitory);

            manager.controledDormitory = NewDormitory;

            MessageBox.Show("Dormitory added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            new DormitoryManagementForm().Show();
            this.Close();
        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            new DormitoryManagementForm().Show();
            this.Close();
        }
    }
}
