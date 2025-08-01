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
            cmbDormitories.DataSource = DATA.Dormitories;
            cmbDormitories.SelectedIndex = -1;
            // Optional: Load dormitory list into comboBox
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Dormitory selectedDormitory = cmbDormitories.SelectedItem as Dormitory;

            if (selectedDormitory == null)
            {
                MessageBox.Show("Please select a dormitory to delete.");
                return;
            }

            // Delete logic here (e.g., remove from file or list)
            DATA.Dormitories.Remove(selectedDormitory);

            if (selectedDormitory.DormitoryManager != null)
                selectedDormitory.DormitoryManager.ControledDormitory = null;

            cmbDormitories.DataSource = null;
            cmbDormitories.DataSource = DATA.Dormitories;
            cmbDormitories.SelectedIndex = -1;
            MessageBox.Show($"Dormitory '{selectedDormitory}' has been deleted.");

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            new DormitoryManagementForm().Show();
            this.Close();
        }
    }
}
