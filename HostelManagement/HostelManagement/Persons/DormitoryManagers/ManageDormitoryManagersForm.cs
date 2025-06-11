using HostelManagement.People;
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
    public partial class ManageDormitoryManagersForm : Form
    {
        // private List<DormitoryManager> managerList;
        private List<string> managerList;

        public ManageDormitoryManagersForm()
        {
            InitializeComponent();
        }

        private void ManageDormitoryManagersForm_Load(object sender, EventArgs e)
        {
            // Load and display all managers
            // managerList = DormitoryManagerRepository.GetAll(); // فرضی
            RefreshManagerList();
        }

        private void RefreshManagerList()
        {
            lstManagers.Items.Clear();
            foreach (var m in managerList)
            {
                // lstManagers.Items.Add($"{m.FirstName} {m.LastName} - {m.Position}");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = lstManagers.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Please select a manager to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // var selectedManager = managerList[index];
            // var editForm = new EditDormitoryManagerForm(selectedManager);
            // if (editForm.ShowDialog() == DialogResult.OK)
            // {
            //     RefreshManagerList();
            // }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstManagers.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Please select a manager to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this manager?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // DormitoryManagerRepository.Delete(managerList[index]); // فرضی
                managerList.RemoveAt(index);
                RefreshManagerList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new PersonManagementForm().Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddDormitoryManagerForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // دوباره گرفتن لیست به‌روز شده از دیتابیس یا منبع داده
                // managerList = DormitoryManagerRepository.GetAll(); // تابع فرضی
                RefreshManagerList();
            }
        }

    }
}
