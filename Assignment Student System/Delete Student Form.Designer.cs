namespace Assignment_Student_System
{
    partial class frmDltStudentPage
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
            this.lblStudyStatus = new System.Windows.Forms.Label();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.chkConfirmDlt = new System.Windows.Forms.CheckBox();
            this.btnBack_studystatus = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudyStatus
            // 
            this.lblStudyStatus.AutoSize = true;
            this.lblStudyStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblStudyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudyStatus.Location = new System.Drawing.Point(182, 46);
            this.lblStudyStatus.Name = "lblStudyStatus";
            this.lblStudyStatus.Size = new System.Drawing.Size(185, 24);
            this.lblStudyStatus.TabIndex = 0;
            this.lblStudyStatus.Text = "On-going Students";
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 20;
            this.lstStudents.Location = new System.Drawing.Point(49, 102);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(428, 204);
            this.lstStudents.TabIndex = 1;
            // 
            // chkConfirmDlt
            // 
            this.chkConfirmDlt.AutoSize = true;
            this.chkConfirmDlt.Location = new System.Drawing.Point(314, 346);
            this.chkConfirmDlt.Name = "chkConfirmDlt";
            this.chkConfirmDlt.Size = new System.Drawing.Size(134, 24);
            this.chkConfirmDlt.TabIndex = 2;
            this.chkConfirmDlt.Text = "Confirm Delete";
            this.chkConfirmDlt.UseVisualStyleBackColor = true;
            this.chkConfirmDlt.CheckedChanged += new System.EventHandler(this.chkConfirmDlt_CheckedChanged);
            // 
            // btnBack_studystatus
            // 
            this.btnBack_studystatus.Location = new System.Drawing.Point(388, 437);
            this.btnBack_studystatus.Name = "btnBack_studystatus";
            this.btnBack_studystatus.Size = new System.Drawing.Size(89, 38);
            this.btnBack_studystatus.TabIndex = 4;
            this.btnBack_studystatus.Text = "Back";
            this.btnBack_studystatus.UseVisualStyleBackColor = true;
            this.btnBack_studystatus.Click += new System.EventHandler(this.btnBack_studystatus_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(49, 437);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 38);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDltStudentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 501);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack_studystatus);
            this.Controls.Add(this.chkConfirmDlt);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.lblStudyStatus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDltStudentPage";
            this.Text = "Delete Student Page";
            this.Load += new System.EventHandler(this.frmDltStudentPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudyStatus;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.CheckBox chkConfirmDlt;
        private System.Windows.Forms.Button btnBack_studystatus;
        private System.Windows.Forms.Button btnDelete;
    }
}