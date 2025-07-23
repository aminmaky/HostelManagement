namespace HostelManagement.Persons.DormitoryManagers.DormitoryManagersControl
{
    partial class EditDormitoryManagerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPosition = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            btnUpdate = new Button();
            btnCancel = new Button();
            txtIDNumber = new TextBox();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(30, 30);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(250, 31);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(30, 70);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(250, 31);
            txtLastName.TabIndex = 1;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(30, 110);
            txtPosition.Name = "txtPosition";
            txtPosition.PlaceholderText = "Position";
            txtPosition.Size = new Size(250, 31);
            txtPosition.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(30, 184);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone";
            txtPhone.Size = new Size(250, 31);
            txtPhone.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(30, 221);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address";
            txtAddress.Size = new Size(250, 31);
            txtAddress.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(30, 268);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 30);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(160, 268);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 30);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // txtIDNumber
            // 
            txtIDNumber.Location = new Point(30, 147);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.PlaceholderText = "ID Number";
            txtIDNumber.Size = new Size(250, 31);
            txtIDNumber.TabIndex = 7;
            // 
            // EditDormitoryManagerForm
            // 
            ClientSize = new Size(320, 310);
            Controls.Add(txtIDNumber);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtPosition);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Name = "EditDormitoryManagerForm";
            Text = "Edit Dormitory Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private TextBox txtIDNumber;
    }
}
