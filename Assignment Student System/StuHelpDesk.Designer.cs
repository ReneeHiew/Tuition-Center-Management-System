namespace Assignment_Student_System
{
    partial class StuHelpDesk
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
            this.lblCurrentSub = new System.Windows.Forms.Label();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.lblRequest = new System.Windows.Forms.Label();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblChangeRequest = new System.Windows.Forms.Label();
            this.lblHelpDesk = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbPenReq = new System.Windows.Forms.GroupBox();
            this.PendingRequest = new System.Windows.Forms.ListBox();
            this.lblNewSub = new System.Windows.Forms.Label();
            this.cmbCurrentSub = new System.Windows.Forms.ComboBox();
            this.cmbNewSub = new System.Windows.Forms.ComboBox();
            this.gbPenReq.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrentSub
            // 
            this.lblCurrentSub.AutoSize = true;
            this.lblCurrentSub.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentSub.Location = new System.Drawing.Point(274, 246);
            this.lblCurrentSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentSub.Name = "lblCurrentSub";
            this.lblCurrentSub.Size = new System.Drawing.Size(203, 31);
            this.lblCurrentSub.TabIndex = 20;
            this.lblCurrentSub.Text = "Current Subjects:";
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSendRequest.Location = new System.Drawing.Point(531, 408);
            this.btnSendRequest.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(162, 38);
            this.btnSendRequest.TabIndex = 13;
            this.btnSendRequest.Text = "Send Request";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRequest.Location = new System.Drawing.Point(382, 199);
            this.lblRequest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(194, 31);
            this.lblRequest.TabIndex = 16;
            this.lblRequest.Text = "Student Request";
            // 
            // txtStuName
            // 
            this.txtStuName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStuName.Location = new System.Drawing.Point(453, 131);
            this.txtStuName.Margin = new System.Windows.Forms.Padding(2);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.PlaceholderText = "Enter Name";
            this.txtStuName.Size = new System.Drawing.Size(205, 30);
            this.txtStuName.TabIndex = 15;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentName.Location = new System.Drawing.Point(274, 130);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(175, 31);
            this.lblStudentName.TabIndex = 14;
            this.lblStudentName.Text = "Student Name:";
            // 
            // lblChangeRequest
            // 
            this.lblChangeRequest.AutoSize = true;
            this.lblChangeRequest.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChangeRequest.Location = new System.Drawing.Point(274, 89);
            this.lblChangeRequest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChangeRequest.Name = "lblChangeRequest";
            this.lblChangeRequest.Size = new System.Drawing.Size(280, 31);
            this.lblChangeRequest.TabIndex = 12;
            this.lblChangeRequest.Text = "Change Subject Request";
            // 
            // lblHelpDesk
            // 
            this.lblHelpDesk.AutoSize = true;
            this.lblHelpDesk.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHelpDesk.Location = new System.Drawing.Point(189, 19);
            this.lblHelpDesk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHelpDesk.Name = "lblHelpDesk";
            this.lblHelpDesk.Size = new System.Drawing.Size(312, 42);
            this.lblHelpDesk.TabIndex = 11;
            this.lblHelpDesk.Text = "Student Help Desk";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(31, 283);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 38);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(421, 408);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 38);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbPenReq
            // 
            this.gbPenReq.Controls.Add(this.btnDelete);
            this.gbPenReq.Controls.Add(this.PendingRequest);
            this.gbPenReq.Location = new System.Drawing.Point(24, 81);
            this.gbPenReq.Margin = new System.Windows.Forms.Padding(2);
            this.gbPenReq.Name = "gbPenReq";
            this.gbPenReq.Padding = new System.Windows.Forms.Padding(2);
            this.gbPenReq.Size = new System.Drawing.Size(229, 333);
            this.gbPenReq.TabIndex = 26;
            this.gbPenReq.TabStop = false;
            this.gbPenReq.Text = "Pending Request";
            // 
            // PendingRequest
            // 
            this.PendingRequest.FormattingEnabled = true;
            this.PendingRequest.ItemHeight = 20;
            this.PendingRequest.Location = new System.Drawing.Point(5, 24);
            this.PendingRequest.Margin = new System.Windows.Forms.Padding(2);
            this.PendingRequest.Name = "PendingRequest";
            this.PendingRequest.Size = new System.Drawing.Size(220, 244);
            this.PendingRequest.TabIndex = 25;
            // 
            // lblNewSub
            // 
            this.lblNewSub.AutoSize = true;
            this.lblNewSub.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewSub.Location = new System.Drawing.Point(274, 293);
            this.lblNewSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewSub.Name = "lblNewSub";
            this.lblNewSub.Size = new System.Drawing.Size(169, 31);
            this.lblNewSub.TabIndex = 27;
            this.lblNewSub.Text = "New Subjects:";
            // 
            // cmbCurrentSub
            // 
            this.cmbCurrentSub.FormattingEnabled = true;
            this.cmbCurrentSub.Location = new System.Drawing.Point(494, 251);
            this.cmbCurrentSub.Name = "cmbCurrentSub";
            this.cmbCurrentSub.Size = new System.Drawing.Size(151, 28);
            this.cmbCurrentSub.TabIndex = 28;
            // 
            // cmbNewSub
            // 
            this.cmbNewSub.FormattingEnabled = true;
            this.cmbNewSub.Location = new System.Drawing.Point(494, 298);
            this.cmbNewSub.Name = "cmbNewSub";
            this.cmbNewSub.Size = new System.Drawing.Size(151, 28);
            this.cmbNewSub.TabIndex = 29;
            // 
            // StuHelpDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 456);
            this.Controls.Add(this.cmbNewSub);
            this.Controls.Add(this.cmbCurrentSub);
            this.Controls.Add(this.lblNewSub);
            this.Controls.Add(this.gbPenReq);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCurrentSub);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblChangeRequest);
            this.Controls.Add(this.lblHelpDesk);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StuHelpDesk";
            this.Text = "StuHelpDesk";
            this.Load += new System.EventHandler(this.StuHelpDesk_Load);
            this.gbPenReq.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblCurrentSub;
        private Button btnSendRequest;
        private Label lblRequest;
        private TextBox txtStuName;
        private Label lblStudentName;
        private Label lblChangeRequest;
        private Label lblHelpDesk;
        private readonly EventHandler lstRequest_SelectedIndexChanged;
        private Button btnDelete;
        private Button btnBack;
        private GroupBox gbPenReq;
        private Label lblNewSub;
        private ListBox PendingRequest;
        private ComboBox cmbCurrentSub;
        private ComboBox cmbNewSub;
    }
}