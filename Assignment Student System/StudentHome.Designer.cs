namespace Assignment_Student_System
{
    partial class StudentHome
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
            this.lblStuName = new System.Windows.Forms.Label();
            this.btnHelpDesk = new System.Windows.Forms.Button();
            this.btnStuProfile = new System.Windows.Forms.Button();
            this.btnClassSchedule = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStuName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStuName.Location = new System.Drawing.Point(370, 38);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(2, 57);
            this.lblStuName.TabIndex = 9;
            // 
            // btnHelpDesk
            // 
            this.btnHelpDesk.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHelpDesk.Location = new System.Drawing.Point(100, 275);
            this.btnHelpDesk.Name = "btnHelpDesk";
            this.btnHelpDesk.Size = new System.Drawing.Size(464, 56);
            this.btnHelpDesk.TabIndex = 8;
            this.btnHelpDesk.Text = "Student Help Desk";
            this.btnHelpDesk.UseVisualStyleBackColor = true;
            this.btnHelpDesk.Click += new System.EventHandler(this.btnHelpDesk_Click);
            // 
            // btnStuProfile
            // 
            this.btnStuProfile.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStuProfile.Location = new System.Drawing.Point(100, 199);
            this.btnStuProfile.Name = "btnStuProfile";
            this.btnStuProfile.Size = new System.Drawing.Size(464, 56);
            this.btnStuProfile.TabIndex = 7;
            this.btnStuProfile.Text = "Student Profile";
            this.btnStuProfile.UseVisualStyleBackColor = true;
            this.btnStuProfile.Click += new System.EventHandler(this.btnStuProfile_Click);
            // 
            // btnClassSchedule
            // 
            this.btnClassSchedule.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClassSchedule.Location = new System.Drawing.Point(100, 126);
            this.btnClassSchedule.Name = "btnClassSchedule";
            this.btnClassSchedule.Size = new System.Drawing.Size(464, 56);
            this.btnClassSchedule.TabIndex = 6;
            this.btnClassSchedule.Text = "Class Schedule";
            this.btnClassSchedule.UseVisualStyleBackColor = true;
            this.btnClassSchedule.Click += new System.EventHandler(this.btnClassSchedule_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(109, 38);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(234, 55);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Welcome, ";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.Location = new System.Drawing.Point(100, 350);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(464, 56);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 434);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblStuName);
            this.Controls.Add(this.btnHelpDesk);
            this.Controls.Add(this.btnStuProfile);
            this.Controls.Add(this.btnClassSchedule);
            this.Controls.Add(this.lblWelcome);
            this.Name = "StudentHome";
            this.Text = "StudentHome";
            this.Load += new System.EventHandler(this.StudentHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStuName;
        private Button btnHelpDesk;
        private Button btnStuProfile;
        private Button btnClassSchedule;
        private Label lblWelcome;
        private Button btnLogOut;
    }
}