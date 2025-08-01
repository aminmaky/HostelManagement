using HostelManagement.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;


namespace HostelManagement.Assets
{
    public partial class AssignAssetToStudentForm : Form
    {
        public AssignAssetToStudentForm()
        {
            InitializeComponent();
        }

        private void AssignAssetToStudentForm_Load(object sender, EventArgs e)
        {
            LoadPersonalAssets();
        }

        private void LoadPersonalAssets()
        {
            CmbAssets.Items.Clear();
            cmbStudents.Items.Clear();

            foreach (var student in DATA.Students)
                cmbStudents.Items.Add(student);

            foreach (var tool in DATA.Tools)
            {
                if (tool.Type != Asset.Fridge && tool.OwnerName == null)
                {
                    CmbAssets.Items.Add(tool);
                }
            }

            cmbStudents.SelectedIndex = -1;
            CmbAssets.SelectedIndex = -1;
        }

        public bool AssignToolToStudent(Student student, Tool tool)
        {
            if (tool.Type == Asset.Fridge)
            {
                MessageBox.Show("Fridge cannot be assigned to a student individually.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (student.Tools == null)
                student.Tools = new List<Tool>();

            if (student.Tools.Any(t => t.Type == tool.Type))
            {
                MessageBox.Show($"This student already has a {tool.Type}.", "Assignment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            student.Tools.Add(tool);
            tool.OwnerName = student;

            MessageBox.Show($"{tool.Type} assigned to {student.Firstname}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        private void BtnAssign_Click(object sender, EventArgs e)
        {
            if (CmbAssets.SelectedItem == null || cmbStudents.SelectedItem == null)
            {
                MessageBox.Show("Please select an asset and a student.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tool selectedTool = CmbAssets.SelectedItem as Tool;
            Student selectedStudent = cmbStudents.SelectedItem as Student;

            if (selectedTool != null && selectedStudent != null)
            {
                bool success = AssignToolToStudent(selectedStudent, selectedTool);
                if (success)
                {
                    CmbAssets.Items.Remove(selectedTool);
                    CmbAssets.SelectedIndex = -1;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new AssetManagementForm().Show();
            this.Close();
        }
    }
}
