namespace HostelManagement
{
    partial class AddStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtStudentID;
        private TextBox txtNationalID;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Button BtnSubmit;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;

        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtStudentID = new TextBox();
            txtNationalID = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            BtnSubmit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(120, 20);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 31);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(120, 60);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 31);
            txtLastName.TabIndex = 1;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(120, 100);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(200, 31);
            txtStudentID.TabIndex = 2;
            // 
            // txtNationalID
            // 
            txtNationalID.Location = new Point(120, 140);
            txtNationalID.Name = "txtNationalID";
            txtNationalID.Size = new Size(200, 31);
            txtNationalID.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(120, 180);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 31);
            txtPhone.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(120, 220);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 31);
            txtAddress.TabIndex = 5;
            // 
            // BtnSubmit
            // 
            BtnSubmit.Location = new Point(120, 270);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(100, 30);
            BtnSubmit.TabIndex = 6;
            BtnSubmit.Text = "Submit";
            BtnSubmit.Click += BtnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.Location = new Point(20, 100);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 3;
            label3.Text = "Student ID";
            // 
            // label4
            // 
            label4.Location = new Point(20, 140);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 4;
            label4.Text = "National ID";
            // 
            // label5
            // 
            label5.Location = new Point(20, 180);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 5;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.Location = new Point(20, 220);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 6;
            label6.Text = "Address";
            // 
            // AddStudent
            // 
            ClientSize = new Size(360, 330);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentID);
            Controls.Add(txtNationalID);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(BtnSubmit);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Student";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

    }
}