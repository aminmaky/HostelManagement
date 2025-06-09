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
    public partial class AddDormitoryForm : Form
    {
        public AddDormitoryForm()
        {
            InitializeComponent();
        }

        private void AddDormitoryForm_Load(object sender, EventArgs e)
        {
            // Optional: Load data such as list of dorm managers or blocks
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // TODO: Add dormitory data to storage

            MessageBox.Show("Dormitory added successfully!");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            new DormitoryManagementForm().Show();
            this.Close();
        }
    }
}
