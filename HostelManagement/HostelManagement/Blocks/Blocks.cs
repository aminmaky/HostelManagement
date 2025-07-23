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
            cmbDormitories.DataSource = null;
            cmbDormitories.DataSource = DATA.Dormitories;
            cmbDormitories.DisplayMember = "Name";
            cmbDormitories.SelectedIndex = -1;
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
                Dormitory selectedDormitory = cmbDormitories.SelectedItem as Dormitory;
                new AddBlockForm(selectedDormitory).Show();
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
            Dormitory selectedDormitory = cmbDormitories.SelectedItem as Dormitory;
            new DeleteBlockForm(selectedDormitory).Show();
            this.Hide();
        }

        private void BtnEditBlock_Click(object sender, EventArgs e)
        {
            if (cmbDormitories.SelectedItem == null)
            {
                MessageBox.Show("Please select a dormitory first.");
                return;
            }
            Dormitory selectedDormitory = cmbDormitories.SelectedItem as Dormitory;
            new EditBlockForm(selectedDormitory).Show();
            this.Hide();
        }

        private void BtnViewBlocks_Click(object sender, EventArgs e)
        {
            if (cmbDormitories.SelectedItem == null)
            {
                MessageBox.Show("Please select a dormitory first.");
                return;
            }
            Dormitory selectedDormitory = cmbDormitories.SelectedItem as Dormitory;
            new BlockListForm(selectedDormitory).Show();
            this.Hide();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Close();
        }
    }
}
