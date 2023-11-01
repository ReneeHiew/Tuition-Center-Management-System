namespace Assignment_Student_System
{
    partial class frmReceptionistProfile
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
            this.lblReceptionist_Role = new System.Windows.Forms.Label();
            this.lblContactNum = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnBack_receptionistprofilepage = new System.Windows.Forms.Button();
            this.lblName_Out = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblIC = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblIC_Out = new System.Windows.Forms.Label();
            this.lblCountry_Out = new System.Windows.Forms.Label();
            this.lblGender_Out = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactNum = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername_Out = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReceptionist_Role
            // 
            this.lblReceptionist_Role.AutoSize = true;
            this.lblReceptionist_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReceptionist_Role.Location = new System.Drawing.Point(327, 52);
            this.lblReceptionist_Role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceptionist_Role.Name = "lblReceptionist_Role";
            this.lblReceptionist_Role.Size = new System.Drawing.Size(75, 15);
            this.lblReceptionist_Role.TabIndex = 2;
            this.lblReceptionist_Role.Text = "Receptionist";
            // 
            // lblContactNum
            // 
            this.lblContactNum.AutoSize = true;
            this.lblContactNum.Location = new System.Drawing.Point(29, 346);
            this.lblContactNum.Name = "lblContactNum";
            this.lblContactNum.Size = new System.Drawing.Size(129, 20);
            this.lblContactNum.TabIndex = 4;
            this.lblContactNum.Text = "Contact Number:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(401, 127);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username:";
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Location = new System.Drawing.Point(23, 457);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(143, 43);
            this.btnUpdateProfile.TabIndex = 6;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnBack_receptionistprofilepage
            // 
            this.btnBack_receptionistprofilepage.Location = new System.Drawing.Point(602, 457);
            this.btnBack_receptionistprofilepage.Name = "btnBack_receptionistprofilepage";
            this.btnBack_receptionistprofilepage.Size = new System.Drawing.Size(96, 43);
            this.btnBack_receptionistprofilepage.TabIndex = 7;
            this.btnBack_receptionistprofilepage.Text = "Back";
            this.btnBack_receptionistprofilepage.UseVisualStyleBackColor = true;
            this.btnBack_receptionistprofilepage.Click += new System.EventHandler(this.btnBack_receptionistprofilepage_Click);
            // 
            // lblName_Out
            // 
            this.lblName_Out.AutoSize = true;
            this.lblName_Out.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName_Out.Location = new System.Drawing.Point(338, 16);
            this.lblName_Out.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName_Out.Name = "lblName_Out";
            this.lblName_Out.Size = new System.Drawing.Size(2, 22);
            this.lblName_Out.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(29, 291);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 20);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address:";
            // 
            // lblIC
            // 
            this.lblIC.AutoSize = true;
            this.lblIC.Location = new System.Drawing.Point(29, 127);
            this.lblIC.Name = "lblIC";
            this.lblIC.Size = new System.Drawing.Size(29, 20);
            this.lblIC.TabIndex = 9;
            this.lblIC.Text = "IC:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(29, 235);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(68, 20);
            this.lblCountry.TabIndex = 10;
            this.lblCountry.Text = "Country:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(29, 180);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(67, 20);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender:";
            // 
            // lblIC_Out
            // 
            this.lblIC_Out.AutoSize = true;
            this.lblIC_Out.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIC_Out.Location = new System.Drawing.Point(195, 125);
            this.lblIC_Out.Name = "lblIC_Out";
            this.lblIC_Out.Size = new System.Drawing.Size(2, 22);
            this.lblIC_Out.TabIndex = 13;
            // 
            // lblCountry_Out
            // 
            this.lblCountry_Out.AutoSize = true;
            this.lblCountry_Out.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCountry_Out.Location = new System.Drawing.Point(195, 233);
            this.lblCountry_Out.Name = "lblCountry_Out";
            this.lblCountry_Out.Size = new System.Drawing.Size(2, 22);
            this.lblCountry_Out.TabIndex = 15;
            // 
            // lblGender_Out
            // 
            this.lblGender_Out.AutoSize = true;
            this.lblGender_Out.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGender_Out.Location = new System.Drawing.Point(195, 178);
            this.lblGender_Out.Name = "lblGender_Out";
            this.lblGender_Out.Size = new System.Drawing.Size(2, 22);
            this.lblGender_Out.TabIndex = 14;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(195, 288);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(180, 26);
            this.txtAddress.TabIndex = 19;
            // 
            // txtContactNum
            // 
            this.txtContactNum.Location = new System.Drawing.Point(195, 343);
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.Size = new System.Drawing.Size(180, 26);
            this.txtContactNum.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(195, 399);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 26);
            this.txtEmail.TabIndex = 22;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(29, 402);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(533, 174);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 26);
            this.txtPassword.TabIndex = 24;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(401, 180);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername_Out
            // 
            this.lblUsername_Out.AutoSize = true;
            this.lblUsername_Out.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsername_Out.Location = new System.Drawing.Point(537, 127);
            this.lblUsername_Out.Name = "lblUsername_Out";
            this.lblUsername_Out.Size = new System.Drawing.Size(2, 22);
            this.lblUsername_Out.TabIndex = 25;
            // 
            // frmReceptionistProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 515);
            this.Controls.Add(this.lblUsername_Out);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtContactNum);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblCountry_Out);
            this.Controls.Add(this.lblGender_Out);
            this.Controls.Add(this.lblIC_Out);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblIC);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btnBack_receptionistprofilepage);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblContactNum);
            this.Controls.Add(this.lblReceptionist_Role);
            this.Controls.Add(this.lblName_Out);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReceptionistProfile";
            this.Text = "Receptionist Profile Page";
            this.Load += new System.EventHandler(this.frmReceptionistProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblReceptionist_Role;
        private System.Windows.Forms.Label lblContactNum;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnBack_receptionistprofilepage;
        private System.Windows.Forms.Label lblName_Out;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblIC;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblIC_Out;
        private System.Windows.Forms.Label lblCountry_Out;
        private System.Windows.Forms.Label lblGender_Out;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactNum;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername_Out;
    }
}