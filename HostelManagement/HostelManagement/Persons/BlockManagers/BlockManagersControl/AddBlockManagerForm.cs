using HostelManagement.Persons.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement.Persons.BlockManagers
{
    public partial class AddBlockManagerForm : Form
    {
        private List<Student> allStudents;
        private List<Block> allBlocks;

        public AddBlockManagerForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            LoadStudents();
            //LoadBlocks();
        }

        private void LoadStudents()
        {
            allStudents = DATA.Students.Where(s => !(s is BlocksManager)).ToList();
            cmbStudents.Items.Clear();
            foreach (var s in allStudents)
            {
                cmbStudents.Items.Add($"{s.Firstname} {s.Lastname} ({s.StudentId})");
            }
        }

        //private void LoadBlocks()
        //{
        //    allBlocks = DATA.Blocks.Where(b => b.supervisor == null).ToList();
        //    cmbBlocks.Items.Clear();
        //    foreach (var b in allBlocks)
        //    {
        //        cmbBlocks.Items.Add(b.Name);
        //    }
        //}


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedIndex == -1/* || cmbBlocks.SelectedIndex == -1*/)
            {
                MessageBox.Show("Please select a student", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedStudent = allStudents[cmbStudents.SelectedIndex];
            // var selectedBlock = allBlocks[cmbBlocks.SelectedIndex];
            Block selectedBlock = null;
            string Position = txtPosition.Text;
            var blockManager = new BlocksManager(
                selectedStudent.Firstname,
                selectedStudent.Lastname,
                selectedStudent.IdNum,
                selectedStudent.TelNum,
                selectedStudent.Address,
                selectedStudent.StudentId,
                selectedStudent.Room,
                selectedStudent.Block,
                selectedStudent.Dormitory,
                selectedStudent.Tools,
                Position,
                selectedBlock
                );

            // selectedBlock.supervisor = blockManager;
            if (DATA.BlockManagers == null)
                DATA.BlockManagers = new List<BlocksManager>();
            DATA.BlockManagers.Add(blockManager);

            // Save block manager assignment here
            MessageBox.Show($"{selectedStudent} is now add as block manager.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            new BlockManagersForm().Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            new BlockManagersForm().Show();
        }
    }
}
