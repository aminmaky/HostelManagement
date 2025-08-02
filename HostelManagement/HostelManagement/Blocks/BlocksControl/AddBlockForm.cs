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

namespace HostelManagement.Blocks
{
    public partial class AddBlockForm : Form
    {
        private Dormitory dorm;
        public AddBlockForm(Dormitory dormitory)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.dorm = dormitory;
        }


        private void AddBlockForm_Load(object sender, EventArgs e)
        {
            lblDormitoryName.Text = $"Dormitory: {dorm.Name}";

            cmbSupervisor.Items.Clear();
            foreach (var manager in DATA.BlockManagers)
            {
                cmbSupervisor.Items.Add(manager);
            }

            cmbSupervisor.SelectedIndex = -1;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string blockName = txtBlockName.Text.Trim();
            int numFloors, numRooms;

            if (string.IsNullOrWhiteSpace(blockName) ||
                !int.TryParse(txtFloors.Text, out numFloors) ||
                !int.TryParse(txtRooms.Text, out numRooms) ||
                cmbSupervisor.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields correctly.");
                return;
            }

            BlocksManager supervisorName = cmbSupervisor.SelectedItem as BlocksManager;

            Block newBlock = new Block(blockName, numFloors, numRooms, supervisorName, dorm);

            if (dorm.Blocks == null)
                dorm.Blocks = new List<Block>();
            dorm.Blocks.Add(newBlock);

            if (DATA.Blocks == null)
                DATA.Blocks = new List<Block>();
            DATA.Blocks.Add(newBlock);
            supervisorName.ControledBlock = newBlock;

            MessageBox.Show("Block added successfully!");
            new BlockManagementForm().Show();
            this.Close();
        }

        //private void BtnAdd_Click(object sender, EventArgs e)
        //{
        //    string blockName = txtBlockName.Text.Trim();
        //    int numFloors, numRooms;

        //    if (string.IsNullOrWhiteSpace(blockName) ||
        //        !int.TryParse(txtFloors.Text, out numFloors) ||
        //        !int.TryParse(txtRooms.Text, out numRooms) ||
        //        cmbSupervisor.SelectedItem == null)
        //    {
        //        MessageBox.Show("Please fill all fields correctly.");
        //        return;
        //    }
            
        //    // Block block = new Block(blockName, numFloors, numRooms, /*cmbSupervisor.SelectedItem.ToString(), */dorm);

        //    if (dorm.Blocks == null)
        //        dorm.Blocks = new List<Block>();
            
        //    // Save to DB or data structure here...

        //    // dorm.Blocks.Add(block);

        //    MessageBox.Show("Block added successfully!");
        //    new BlockManagementForm().Show();
        //    this.Close();
        //}
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            new BlockManagementForm().Show();
            this.Close();
        }
    }
}
