namespace Assignment_Student_System
{
    partial class frmUpdateSub
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
            this.lblSubChangeRequest = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack_updatesub = new System.Windows.Forms.Button();
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubChangeRequest
            // 
            this.lblSubChangeRequest.AutoSize = true;
            this.lblSubChangeRequest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSubChangeRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubChangeRequest.Location = new System.Drawing.Point(177, 19);
            this.lblSubChangeRequest.Name = "lblSubChangeRequest";
            this.lblSubChangeRequest.Size = new System.Drawing.Size(252, 24);
            this.lblSubChangeRequest.TabIndex = 0;
            this.lblSubChangeRequest.Text = "Subject Change Requests";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(29, 322);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(176, 34);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm Changes";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack_updatesub
            // 
            this.btnBack_updatesub.Location = new System.Drawing.Point(528, 322);
            this.btnBack_updatesub.Name = "btnBack_updatesub";
            this.btnBack_updatesub.Size = new System.Drawing.Size(76, 34);
            this.btnBack_updatesub.TabIndex = 3;
            this.btnBack_updatesub.Text = "Back";
            this.btnBack_updatesub.UseVisualStyleBackColor = true;
            this.btnBack_updatesub.Click += new System.EventHandler(this.btnBack_updatesub_Click);
            // 
            // dgvRequest
            // 
            this.dgvRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRequest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRequest.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRequest.Location = new System.Drawing.Point(42, 61);
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.RowHeadersWidth = 51;
            this.dgvRequest.RowTemplate.Height = 25;
            this.dgvRequest.Size = new System.Drawing.Size(551, 237);
            this.dgvRequest.TabIndex = 4;
            // 
            // frmUpdateSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 397);
            this.Controls.Add(this.dgvRequest);
            this.Controls.Add(this.btnBack_updatesub);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblSubChangeRequest);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUpdateSub";
            this.Text = "Update Subject Enrollment Page";
            this.Load += new System.EventHandler(this.frmUpdateSub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubChangeRequest;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack_updatesub;
        //private myDBDataSet myDBDataSet;
        //private myDBDataSetTableAdapters.requestTableAdapter requestTableAdapter;
        //private myDBDataSet1 myDBDataSet1;
        //private myDBDataSet1TableAdapters.requestTableAdapter requestTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentsubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newsubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridView dgvRequest;
    }
}