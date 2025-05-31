using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement.Blocks
{
    public partial class BlockListForm : Form
    {
        private string dormitoryName;

        public BlockListForm(string dormitoryName)
        {
            InitializeComponent();
            this.dormitoryName = dormitoryName;
        }

        private void BlockListForm_Load(object sender, EventArgs e)
        {
            lblDormitory.Text = $"Dormitory: {dormitoryName}";

            // TODO: Replace with actual data from database
            dgvBlocks.Rows.Add("Block A", 3, 30, "John Doe");
            dgvBlocks.Rows.Add("Block B", 2, 20, "Jane Smith");
            dgvBlocks.Rows.Add("Block C", 4, 40, "Ali Reza");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            new BlockManagementForm().Show();
            this.Close();
        }
    }
}
