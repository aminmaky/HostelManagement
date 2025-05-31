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
    public partial class BlockManagementForm : Form
    {
        public BlockManagementForm()
        {
            InitializeComponent();
        }

        private void BlockManagementForm_Load(object sender, EventArgs e)
        {
            // Sample data for dormitories - replace with actual list
            cmbDormitories.Items.Add("Dorm A");
            cmbDormitories.Items.Add("Dorm B");
        }

        private void BtnAddBlock_Click(object sender, EventArgs e)
        {
            if (cmbDormitories.SelectedItem == null)
            {
                MessageBox.Show("Please select a dormitory first.");
                return;
            }
            else
            {
                new AddBlockForm((string)cmbDormitories.SelectedItem).Show();
                this.Hide();
            }
        }

        private void BtnDeleteBlock_Click(object sender, EventArgs e)
        {
            if (cmbDormitories.SelectedItem == null)
            {
                MessageBox.Show("Please select a dormitory first.");
                return;
            }
            new DeleteBlockForm((string)cmbDormitories.SelectedItem).Show();
            this.Hide();
        }

        private void BtnEditBlock_Click(object sender, EventArgs e)
        {
            if (cmbDormitories.SelectedItem == null)
            {
                MessageBox.Show("Please select a dormitory first.");
                return;
            }
            new EditBlockForm((string)cmbDormitories.SelectedItem).Show();
            this.Hide();
        }

        private void BtnViewBlocks_Click(object sender, EventArgs e)
        {
            if (cmbDormitories.SelectedItem == null)
            {
                MessageBox.Show("Please select a dormitory first.");
                return;
            }
            new BlockListForm((string)cmbDormitories.SelectedItem).Show();
            this.Hide();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Close();
        }
    }
}
