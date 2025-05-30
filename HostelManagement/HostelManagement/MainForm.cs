using HostelManagement.Blocks;
using HostelManagement.Dormitories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDormitories_Click(object sender, EventArgs e)
        {
            new DormitoryManagementForm().Show();
            this.Hide();
        }

        private void btnBlocks_Click(object sender, EventArgs e)
        {
            new BlockManagementForm().Show();
            this.Hide();
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            new StudentManagement().Show();
            this.Hide();
        }

        private void btnAssets_Click(object sender, EventArgs e)
        {
            // TODO: Open Assets form
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            // TODO: Open Reports form
        }

    }
}
