namespace Assignment_Student_System
{
    partial class StuUpdateProfile
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
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.lblStudentNum = new System.Windows.Forms.Label();
            this.lblStudentEmail = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.llblStudentProfile = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtConNum = new System.Windows.Forms.TextBox();
            this.lblStuName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(433, 375);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(195, 36);
            this.btnCancel.TabIndex = 67;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveChange.Location = new System.Drawing.Point(206, 375);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(213, 36);
            this.btnSaveChange.TabIndex = 64;
            this.btnSaveChange.Text = "Save Changes\r\n";
            this.btnSaveChange.UseVisualStyleBackColor = true;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // lblStudentNum
            // 
            this.lblStudentNum.AutoSize = true;
            this.lblStudentNum.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentNum.Location = new System.Drawing.Point(193, 288);
            this.lblStudentNum.Name = "lblStudentNum";
            this.lblStudentNum.Size = new System.Drawing.Size(232, 36);
            this.lblStudentNum.TabIndex = 60;
            this.lblStudentNum.Text = "Contact Number:";
            // 
            // lblStudentEmail
            // 
            this.lblStudentEmail.AutoSize = true;
            this.lblStudentEmail.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentEmail.Location = new System.Drawing.Point(193, 227);
            this.lblStudentEmail.Name = "lblStudentEmail";
            this.lblStudentEmail.Size = new System.Drawing.Size(99, 36);
            this.lblStudentEmail.TabIndex = 59;
            this.lblStudentEmail.Text = "Email:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentName.Location = new System.Drawing.Point(193, 102);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(202, 36);
            this.lblStudentName.TabIndex = 55;
            this.lblStudentName.Text = "Student Name:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(193, 160);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(144, 36);
            this.lblPassword.TabIndex = 54;
            this.lblPassword.Text = "Password:";
            // 
            // llblStudentProfile
            // 
            this.llblStudentProfile.AutoSize = true;
            this.llblStudentProfile.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llblStudentProfile.Location = new System.Drawing.Point(206, 22);
            this.llblStudentProfile.Name = "llblStudentProfile";
            this.llblStudentProfile.Size = new System.Drawing.Size(381, 46);
            this.llblStudentProfile.TabIndex = 51;
            this.llblStudentProfile.Text = "Student Update Profile";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(343, 165);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(216, 31);
            this.txtPassword.TabIndex = 69;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(298, 232);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 31);
            this.txtEmail.TabIndex = 70;
            // 
            // txtConNum
            // 
            this.txtConNum.Location = new System.Drawing.Point(431, 293);
            this.txtConNum.Name = "txtConNum";
            this.txtConNum.Size = new System.Drawing.Size(197, 31);
            this.txtConNum.TabIndex = 71;
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStuName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStuName.Location = new System.Drawing.Point(401, 102);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(2, 38);
            this.lblStuName.TabIndex = 72;
            // 
            // StuUpdateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStuName);
            this.Controls.Add(this.txtConNum);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveChange);
            this.Controls.Add(this.lblStudentNum);
            this.Controls.Add(this.lblStudentEmail);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.llblStudentProfile);
            this.Name = "StuUpdateProfile";
            this.Text = "StuUpdateProfile";
            this.Load += new System.EventHandler(this.StuUpdateProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnSaveChange;
        private Label lblStudentNum;
        private Label lblStudentEmail;
        private Label lblStudentName;
        private Label lblPassword;
        private Label llblStudentProfile;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtConNum;
        private Label lblStuName;
    }
}