namespace Assignment_Student_System
{
    partial class UpdateClass
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
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblSubjectOutput = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.txtTime = new System.Windows.Forms.MaskedTextBox();
            this.lstSubject = new System.Windows.Forms.ListBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(7, 9);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(49, 15);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Subject:";
            // 
            // lblSubjectOutput
            // 
            this.lblSubjectOutput.AutoSize = true;
            this.lblSubjectOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubjectOutput.Location = new System.Drawing.Point(64, 9);
            this.lblSubjectOutput.Name = "lblSubjectOutput";
            this.lblSubjectOutput.Size = new System.Drawing.Size(2, 17);
            this.lblSubjectOutput.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(22, 32);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(34, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(20, 61);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 15);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(279, 277);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(64, 29);
            this.txtDate.Mask = "00/00/0000";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 23);
            this.txtDate.TabIndex = 7;
            this.txtDate.ValidatingType = typeof(System.DateTime);
            this.txtDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDate_MaskInputRejected);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(64, 58);
            this.txtTime.Mask = "00:00";
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 23);
            this.txtTime.TabIndex = 8;
            this.txtTime.ValidatingType = typeof(System.DateTime);
            // 
            // lstSubject
            // 
            this.lstSubject.FormattingEnabled = true;
            this.lstSubject.ItemHeight = 15;
            this.lstSubject.Location = new System.Drawing.Point(7, 99);
            this.lstSubject.Name = "lstSubject";
            this.lstSubject.Size = new System.Drawing.Size(263, 229);
            this.lstSubject.TabIndex = 9;
            this.lstSubject.SelectedIndexChanged += new System.EventHandler(this.lstSubject_SelectedIndexChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(279, 248);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(279, 305);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 11;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // UpdateClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 341);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lstSubject);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSubjectOutput);
            this.Controls.Add(this.lblSubject);
            this.Name = "UpdateClass";
            this.Text = "UpdateClass";
            this.Load += new System.EventHandler(this.UpdateClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSubject;
        private Label lblSubjectOutput;
        private Label lblDate;
        private Label lblTime;
        private Button btnUpdate;
        private MaskedTextBox txtDate;
        private MaskedTextBox txtTime;
        private ListBox lstSubject;
        private Button btnConfirm;
        private Button btnCancle;
    }
}