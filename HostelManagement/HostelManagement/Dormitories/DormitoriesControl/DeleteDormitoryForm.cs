using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement.Dormitories
{
    public partial class DeleteDormitoryForm : Form
    {
        public DeleteDormitoryForm()
        {
            InitializeComponent();
        }

        private void DeleteDormitoryForm_Load(object sender, EventArgs e)
        {
            // Optional: Load dormitory list into comboBox
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string selectedDormitory = cmbDormitories.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(selectedDormitory))
            {
                MessageBox.Show("Please select a dormitory to delete.");
                return;
            }

            // Delete logic here (e.g., remove from file or list)
            MessageBox.Show($"Dormitory '{selectedDormitory}' has been deleted.");

            cmbDormitories.Items.Remove(selectedDormitory);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            new DormitoryManagementForm().Show();
            this.Close();
        }
    }
}
