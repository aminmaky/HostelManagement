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
using static System.ComponentModel.Design.ObjectSelectorEditor;

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
            cmbDormitories.DataSource = null;
            cmbDormitories.DataSource = DATA.Dormitories;
            cmbDormitories.DisplayMember = "Name";
            cmbDormitories.SelectedIndex = -1;
            cmbManager.DataSource = DATA.DormitoryManagers;
            txtName.Text = "";
            txtAddress.Text = "";
            txtCapacity.Text = "";
            cmbManager.SelectedIndex = -1;

        }

        private void CmbDormitories_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load dormitory data based on selection (placeholder data here)

            Dormitory selected = cmbDormitories.SelectedItem as Dormitory;

            if (selected == null)
                return;

            txtName.Text = selected.Name;
            txtAddress.Text = selected.Address;
            txtCapacity.Text = selected.Capacity.ToString();
            cmbManager.SelectedItem = selected.DormitoryManager;
            // txtManager.Text = selected.DormitoryManager?.FullName ?? "";
        }


        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            Dormitory selected = cmbDormitories.SelectedItem as Dormitory;
            DormitoryManager newManager = cmbManager.SelectedItem as DormitoryManager;


            if (selected == null)
            {
                MessageBox.Show("Please select a dormitory.");
                return;
            }

            // Save logic goes here
            selected.Name = txtName.Text;
            selected.Address = txtAddress.Text;
            selected.Capacity = int.TryParse(txtCapacity.Text, out int capacity) ? capacity : selected.Capacity;
            selected.DormitoryManager = newManager;
            newManager.ControledDormitory = selected;

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
