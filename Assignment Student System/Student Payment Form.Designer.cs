namespace Assignment_Student_System
{
    partial class frmPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnBack_payment = new System.Windows.Forms.Button();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.lblStudentPayments = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(38, 323);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(137, 41);
            this.btnApprove.TabIndex = 0;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnBack_payment
            // 
            this.btnBack_payment.Location = new System.Drawing.Point(490, 323);
            this.btnBack_payment.Name = "btnBack_payment";
            this.btnBack_payment.Size = new System.Drawing.Size(99, 41);
            this.btnBack_payment.TabIndex = 1;
            this.btnBack_payment.Text = "Back";
            this.btnBack_payment.UseVisualStyleBackColor = true;
            this.btnBack_payment.Click += new System.EventHandler(this.btnBack_payment_Click);
            // 
            // dgvPayment
            // 
            this.dgvPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPayment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayment.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayment.Location = new System.Drawing.Point(38, 76);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.RowHeadersWidth = 51;
            this.dgvPayment.RowTemplate.Height = 25;
            this.dgvPayment.Size = new System.Drawing.Size(551, 229);
            this.dgvPayment.TabIndex = 2;
            // 
            // lblStudentPayments
            // 
            this.lblStudentPayments.AutoSize = true;
            this.lblStudentPayments.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblStudentPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudentPayments.Location = new System.Drawing.Point(227, 30);
            this.lblStudentPayments.Name = "lblStudentPayments";
            this.lblStudentPayments.Size = new System.Drawing.Size(177, 24);
            this.lblStudentPayments.TabIndex = 3;
            this.lblStudentPayments.Text = "Student Payments";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 380);
            this.Controls.Add(this.lblStudentPayments);
            this.Controls.Add(this.dgvPayment);
            this.Controls.Add(this.btnBack_payment);
            this.Controls.Add(this.btnApprove);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPayment";
            this.Text = "Payment Page";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnApprove;
        private Button btnBack_payment;
        private DataGridView dgvPayment;
        private Label lblStudentPayments;
    }
}