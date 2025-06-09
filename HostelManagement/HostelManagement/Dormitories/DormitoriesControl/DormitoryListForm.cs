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
        }

        private void DormitoryListForm_Load(object sender, EventArgs e)
        {
            // Sample static data, replace this with actual data loading
            dgvDormitories.Rows.Add("Dorm A", "Main Street 1", 100, "Mr. John", "Block 1, Block 2");
            dgvDormitories.Rows.Add("Dorm B", "Main Street 2", 150, "Ms. Anna", "Block A, Block B");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            new DormitoryManagementForm().Show();
            this.Close();
        }
    }
}
