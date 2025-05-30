using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HostelManagement.Dormitories
{
    public partial class EditDormitoryForm : Form
    {
        public EditDormitoryForm()
        {
            InitializeComponent();
        }

        private void EditDormitoryForm_Load(object sender, EventArgs e)
        {
            // Sample data, replace with real data loading
            cmbDormitories.Items.Add("Dorm A");
            cmbDormitories.Items.Add("Dorm B");
        }

        private void CmbDormitories_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load dormitory data based on selection (placeholder data here)
            if (cmbDormitories.SelectedItem.ToString() == "Dorm A")
            {
                txtName.Text = "Dorm A";
                txtAddress.Text = "Main Street 1";
                txtCapacity.Text = "100";
                txtManager.Text = "Mr. John";
                txtBlocks.Text = "Block 1, Block 2";
            }
            else if (cmbDormitories.SelectedItem.ToString() == "Dorm B")
            {
                txtName.Text = "Dorm B";
                txtAddress.Text = "Main Street 2";
                txtCapacity.Text = "150";
                txtManager.Text = "Ms. Anna";
                txtBlocks.Text = "Block A, Block B";
            }
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            // Save logic goes here
            MessageBox.Show("Dormitory information updated successfully.");
            new DormitoryManagementForm().Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new DormitoryManagementForm().Show();
            this.Close();
        }
    }
}
