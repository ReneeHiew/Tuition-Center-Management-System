namespace Assignment_Student_System
{
    partial class frmReceptionPage
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
            this.btnRegistration_Page = new System.Windows.Forms.Button();
            this.btnUpdateSubject_Page = new System.Windows.Forms.Button();
            this.btnPayment_Page = new System.Windows.Forms.Button();
            this.btnDltStudent_Page = new System.Windows.Forms.Button();
            this.btnUpdateProfile_Page = new System.Windows.Forms.Button();
            this.lblWelcomeTitle = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistration_Page
            // 
            this.btnRegistration_Page.Location = new System.Drawing.Point(204, 116);
            this.btnRegistration_Page.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistration_Page.Name = "btnRegistration_Page";
            this.btnRegistration_Page.Size = new System.Drawing.Size(253, 36);
            this.btnRegistration_Page.TabIndex = 0;
            this.btnRegistration_Page.Text = "Registration";
            this.btnRegistration_Page.UseVisualStyleBackColor = true;
            this.btnRegistration_Page.UseWaitCursor = true;
            this.btnRegistration_Page.Click += new System.EventHandler(this.btnRegistration_Page_Click);
            // 
            // btnUpdateSubject_Page
            // 
            this.btnUpdateSubject_Page.Location = new System.Drawing.Point(204, 196);
            this.btnUpdateSubject_Page.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateSubject_Page.Name = "btnUpdateSubject_Page";
            this.btnUpdateSubject_Page.Size = new System.Drawing.Size(253, 36);
            this.btnUpdateSubject_Page.TabIndex = 1;
            this.btnUpdateSubject_Page.Text = "Update Subject Enrollment";
            this.btnUpdateSubject_Page.UseVisualStyleBackColor = true;
            this.btnUpdateSubject_Page.UseWaitCursor = true;
            this.btnUpdateSubject_Page.Click += new System.EventHandler(this.btnUpdateSubject_Page_Click);
            // 
            // btnPayment_Page
            // 
            this.btnPayment_Page.Location = new System.Drawing.Point(204, 281);
            this.btnPayment_Page.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPayment_Page.Name = "btnPayment_Page";
            this.btnPayment_Page.Size = new System.Drawing.Size(253, 36);
            this.btnPayment_Page.TabIndex = 2;
            this.btnPayment_Page.Text = "Payment";
            this.btnPayment_Page.UseVisualStyleBackColor = true;
            this.btnPayment_Page.UseWaitCursor = true;
            this.btnPayment_Page.Click += new System.EventHandler(this.btnPayment_Page_Click);
            // 
            // btnDltStudent_Page
            // 
            this.btnDltStudent_Page.Location = new System.Drawing.Point(204, 365);
            this.btnDltStudent_Page.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDltStudent_Page.Name = "btnDltStudent_Page";
            this.btnDltStudent_Page.Size = new System.Drawing.Size(253, 36);
            this.btnDltStudent_Page.TabIndex = 3;
            this.btnDltStudent_Page.Text = "Delete Student";
            this.btnDltStudent_Page.UseVisualStyleBackColor = true;
            this.btnDltStudent_Page.UseWaitCursor = true;
            this.btnDltStudent_Page.Click += new System.EventHandler(this.btnDltStudent_Page_Click);
            // 
            // btnUpdateProfile_Page
            // 
            this.btnUpdateProfile_Page.Location = new System.Drawing.Point(204, 448);
            this.btnUpdateProfile_Page.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateProfile_Page.Name = "btnUpdateProfile_Page";
            this.btnUpdateProfile_Page.Size = new System.Drawing.Size(253, 36);
            this.btnUpdateProfile_Page.TabIndex = 4;
            this.btnUpdateProfile_Page.Text = "Update Profile";
            this.btnUpdateProfile_Page.UseVisualStyleBackColor = true;
            this.btnUpdateProfile_Page.UseWaitCursor = true;
            this.btnUpdateProfile_Page.Click += new System.EventHandler(this.btnUpdateProfile_Page_Click);
            // 
            // lblWelcomeTitle
            // 
            this.lblWelcomeTitle.AutoSize = true;
            this.lblWelcomeTitle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblWelcomeTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWelcomeTitle.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcomeTitle.Location = new System.Drawing.Point(193, 55);
            this.lblWelcomeTitle.Name = "lblWelcomeTitle";
            this.lblWelcomeTitle.Size = new System.Drawing.Size(2, 27);
            this.lblWelcomeTitle.TabIndex = 5;
            this.lblWelcomeTitle.UseWaitCursor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(549, 532);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(137, 39);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.UseWaitCursor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmReceptionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 583);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblWelcomeTitle);
            this.Controls.Add(this.btnUpdateProfile_Page);
            this.Controls.Add(this.btnDltStudent_Page);
            this.Controls.Add(this.btnPayment_Page);
            this.Controls.Add(this.btnUpdateSubject_Page);
            this.Controls.Add(this.btnRegistration_Page);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReceptionPage";
            this.Text = "Receptionist Page";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistration_Page;
        private System.Windows.Forms.Button btnUpdateSubject_Page;
        private System.Windows.Forms.Button btnPayment_Page;
        private System.Windows.Forms.Button btnDltStudent_Page;
        private System.Windows.Forms.Button btnUpdateProfile_Page;
        private System.Windows.Forms.Label lblWelcomeTitle;
        private Button btnLogOut;
    }
}

