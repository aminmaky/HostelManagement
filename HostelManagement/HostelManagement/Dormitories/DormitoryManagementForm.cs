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
    public partial class DormitoryManagementForm : Form
    {
        public DormitoryManagementForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void DormitoryManagementForm_Load(object sender, EventArgs e)
        {
            // Optional: load data or initialize logic
        }

        private void BtnAddDormitory_Click(object sender, EventArgs e)
        {
            new AddDormitoryForm().Show();
            this.Hide();
        }

        private void BtnDeleteDormitory_Click(object sender, EventArgs e)
        {
            new DeleteDormitoryForm().Show();
            this.Hide();
        }

        private void BtnEditDormitory_Click(object sender, EventArgs e)
        {
            new EditDormitoryForm().Show();
            this.Hide();
        }

        private void BtnViewDormitories_Click(object sender, EventArgs e)
        {
            new DormitoryListForm().Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Close();
        }
    }
}
