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
    public partial class DormitoryListForm : Form
    {
        public DormitoryListForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void DormitoryListForm_Load(object sender, EventArgs e)
        {
            // Sample static data, replace this with actual data loading
            //dgvDormitories.Rows.Add("Dorm A", "Main Street 1", 100, "Mr. John", "Block 1, Block 2");
            //dgvDormitories.Rows.Add("Dorm B", "Main Street 2", 150, "Ms. Anna", "Block A, Block B");

            dgvDormitories.Rows.Clear();

            foreach (var dorm in DATA.Dormitories)
            {
                string managerName = dorm.DormitoryManager != null ? dorm.DormitoryManager.ToString() : "No Manager";
                string blocks = dorm.Blocks != null ? string.Join(", ", dorm.Blocks) : "No Blocks";

                dgvDormitories.Rows.Add(dorm.Name, dorm.Address, dorm.Capacity, managerName, blocks);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            new DormitoryManagementForm().Show();
            this.Close();
        }
    }
}
