using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement.Persons.DormitoryManagers.DormitoryManagersControl
{
    public partial class EditDormitoryManagerForm : Form
    {
        private DormitoryManager currentManager;

        public EditDormitoryManagerForm(DormitoryManager manager)
        {
            
            // DormitoryManager manager = new DormitoryManager(); // Must Be Delete!!
            InitializeComponent();
            currentManager = manager;

            // Fill inputs with current values
            txtFirstName.Text = currentManager.Firstname;
            txtLastName.Text = currentManager.Lastname;
            txtPosition.Text = currentManager.Position;
            txtIDNumber.Text = currentManager.IdNum;
            txtPhone.Text = currentManager.TelNum;
            txtAddress.Text = currentManager.Address;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Simple validation
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPosition.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update the object
            currentManager.Firstname = txtFirstName.Text.Trim();
            currentManager.Lastname = txtLastName.Text.Trim();
            currentManager.Position = txtPosition.Text.Trim();
            currentManager.IdNum = txtIDNumber.Text.Trim();
            currentManager.TelNum = txtPhone.Text.Trim();
            currentManager.Address = txtAddress.Text.Trim();

            MessageBox.Show("Manager information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
