namespace HostelManagement.Persons.BlockManagers
{
    partial class AddBlockManagerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblStudent = new Label();
            cmbStudents = new ComboBox();
            btnAdd = new Button();
            btnCancel = new Button();
            txtPosition = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(38, 47);
            lblStudent.Margin = new Padding(4, 0, 4, 0);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(128, 25);
            lblStudent.TabIndex = 0;
            lblStudent.Text = "Select Student:";
            // 
            // cmbStudents
            // 
            cmbStudents.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Location = new Point(188, 42);
            cmbStudents.Margin = new Padding(4, 5, 4, 5);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(249, 33);
            cmbStudents.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(100, 203);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 47);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(250, 203);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 47);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(188, 120);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(249, 31);
            txtPosition.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 126);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 7;
            label1.Text = "Position";
            // 
            // AddBlockManagerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 297);
            Controls.Add(label1);
            Controls.Add(txtPosition);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(cmbStudents);
            Controls.Add(lblStudent);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddBlockManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Block Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtPosition;
        private Label label1;
    }
}
