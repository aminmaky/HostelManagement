namespace HostelManagement.Persons.BlockManagers
{
    partial class AddBlockManagerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblBlock;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.ComboBox cmbBlocks;
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblBlock = new System.Windows.Forms.Label();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.cmbBlocks = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(30, 30);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(92, 17);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Select Student:";
            // 
            // lblBlock
            // 
            this.lblBlock.AutoSize = true;
            this.lblBlock.Location = new System.Drawing.Point(30, 80);
            this.lblBlock.Name = "lblBlock";
            this.lblBlock.Size = new System.Drawing.Size(83, 17);
            this.lblBlock.TabIndex = 1;
            this.lblBlock.Text = "Select Block:";
            // 
            // cmbStudents
            // 
            this.cmbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(150, 27);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(200, 24);
            this.cmbStudents.TabIndex = 2;
            // 
            // cmbBlocks
            // 
            this.cmbBlocks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlocks.FormattingEnabled = true;
            this.cmbBlocks.Location = new System.Drawing.Point(150, 77);
            this.cmbBlocks.Name = "cmbBlocks";
            this.cmbBlocks.Size = new System.Drawing.Size(200, 24);
            this.cmbBlocks.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(80, 130);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Assign";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(200, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddBlockManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 190);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbBlocks);
            this.Controls.Add(this.cmbStudents);
            this.Controls.Add(this.lblBlock);
            this.Controls.Add(this.lblStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddBlockManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Block Manager";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
