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
        private Dormitory dorm;

        public BlockListForm(Dormitory dormitory)
        {
            InitializeComponent();
            this.dorm = dormitory;
        }


        private void BlockListForm_Load(object sender, EventArgs e)
        {
            lblDormitory.Text = $"Dormitory: {dorm.Name}";

            // TODO: Replace with actual data from database
            dgvBlocks.Rows.Clear();
            if (dorm.Blocks != null)
            {
                foreach (var block in dorm.Blocks)
                {
                    dgvBlocks.Rows.Add(block.Name, block.FloresCount, block.RoomCount, block.supervisor);
                }
            }
        }

    

        private void BtnClose_Click(object sender, EventArgs e)
        {
            new BlockManagementForm().Show();
            this.Close();
        }
    }
}
