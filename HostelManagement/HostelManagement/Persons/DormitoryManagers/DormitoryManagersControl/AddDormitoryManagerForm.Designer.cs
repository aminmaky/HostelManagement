namespace HostelManagement.People
{
    partial class AddDormitoryManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;

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
        /// Required method for Designer support — do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPosition = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPosition = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            btnSubmit = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(30, 30);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(101, 25);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(30, 70);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(99, 25);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(30, 110);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(79, 25);
            lblPosition.TabIndex = 4;
            lblPosition.Text = "Position:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(30, 150);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(66, 25);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(30, 190);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(81, 25);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Address:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(150, 27);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 31);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(150, 67);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 31);
            txtLastName.TabIndex = 3;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(150, 107);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(200, 31);
            txtPosition.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(150, 147);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 31);
            txtPhone.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(150, 187);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 31);
            txtAddress.TabIndex = 9;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(30, 230);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(140, 40);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += BtnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(200, 230);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 40);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += BtnBack_Click;
            // 
            // AddDormitoryManagerForm
            // 
            ClientSize = new Size(400, 300);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblPosition);
            Controls.Add(txtPosition);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(btnSubmit);
            Controls.Add(btnBack);
            Name = "AddDormitoryManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Dormitory Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
