using System.Drawing;
using System.Windows.Forms;

namespace HostelManagement.Persons.Students.StudentControl
{
    partial class EditStudentForm
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox cmbStudents;
        private Label lblFirstname;
        private TextBox txtFirstname;
        private Label lblLastname;
        private TextBox txtLastname;
        private Label lblIdNum;
        private TextBox txtIdNum;
        private Label lblTel;
        private TextBox txtTel;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblStudentId;
        private TextBox txtStudentId;
        private Button btnSave;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbStudents = new ComboBox();
            lblFirstname = new Label();
            lblLastname = new Label();
            lblIdNum = new Label();
            lblTel = new Label();
            lblAddress = new Label();
            lblStudentId = new Label();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            txtIdNum = new TextBox();
            txtTel = new TextBox();
            txtAddress = new TextBox();
            txtStudentId = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // cmbStudents
            // 
            cmbStudents.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudents.Location = new Point(38, 25);
            cmbStudents.Margin = new Padding(4);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(399, 33);
            cmbStudents.TabIndex = 0;
            cmbStudents.SelectedIndexChanged += cmbStudents_SelectedIndexChanged;
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Location = new Point(38, 75);
            lblFirstname.Margin = new Padding(4, 0, 4, 0);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(97, 25);
            lblFirstname.TabIndex = 1;
            lblFirstname.Text = "First Name";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Location = new Point(38, 125);
            lblLastname.Margin = new Padding(4, 0, 4, 0);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(95, 25);
            lblLastname.TabIndex = 3;
            lblLastname.Text = "Last Name";
            // 
            // lblIdNum
            // 
            lblIdNum.AutoSize = true;
            lblIdNum.Location = new Point(38, 175);
            lblIdNum.Margin = new Padding(4, 0, 4, 0);
            lblIdNum.Name = "lblIdNum";
            lblIdNum.Size = new Size(100, 25);
            lblIdNum.TabIndex = 5;
            lblIdNum.Text = "ID Number";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(38, 225);
            lblTel.Margin = new Padding(4, 0, 4, 0);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(62, 25);
            lblTel.TabIndex = 7;
            lblTel.Text = "Phone";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(38, 275);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(77, 25);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Address";
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(38, 325);
            lblStudentId.Margin = new Padding(4, 0, 4, 0);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(96, 25);
            lblStudentId.TabIndex = 11;
            lblStudentId.Text = "Student ID";
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(188, 75);
            txtFirstname.Margin = new Padding(4);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(249, 31);
            txtFirstname.TabIndex = 2;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(188, 125);
            txtLastname.Margin = new Padding(4);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(249, 31);
            txtLastname.TabIndex = 4;
            // 
            // txtIdNum
            // 
            txtIdNum.Location = new Point(188, 175);
            txtIdNum.Margin = new Padding(4);
            txtIdNum.Name = "txtIdNum";
            txtIdNum.Size = new Size(249, 31);
            txtIdNum.TabIndex = 6;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(188, 225);
            txtTel.Margin = new Padding(4);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(249, 31);
            txtTel.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(188, 275);
            txtAddress.Margin = new Padding(4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(249, 31);
            txtAddress.TabIndex = 10;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(188, 325);
            txtStudentId.Margin = new Padding(4);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.ReadOnly = true;
            txtStudentId.Size = new Size(249, 31);
            txtStudentId.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(88, 400);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 44);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(250, 400);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 44);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // EditStudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 500);
            Controls.Add(cmbStudents);
            Controls.Add(lblFirstname);
            Controls.Add(txtFirstname);
            Controls.Add(lblLastname);
            Controls.Add(txtLastname);
            Controls.Add(lblIdNum);
            Controls.Add(txtIdNum);
            Controls.Add(lblTel);
            Controls.Add(txtTel);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblStudentId);
            Controls.Add(txtStudentId);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Margin = new Padding(4);
            Name = "EditStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Student";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
