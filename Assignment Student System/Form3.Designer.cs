namespace Assignment_Student_System
{
    partial class Form3
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
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblPlease = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCharges = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.txtTime = new System.Windows.Forms.MaskedTextBox();
            this.lblTutor = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbl50 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbClass
            // 
            this.cmbClass.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "Science ",
            "Mathematics",
            "English"});
            this.cmbClass.Location = new System.Drawing.Point(12, 34);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(456, 89);
            this.cmbClass.TabIndex = 0;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblPlease
            // 
            this.lblPlease.AutoSize = true;
            this.lblPlease.Location = new System.Drawing.Point(12, 9);
            this.lblPlease.Name = "lblPlease";
            this.lblPlease.Size = new System.Drawing.Size(135, 20);
            this.lblPlease.TabIndex = 1;
            this.lblPlease.Text = "Please Select Class:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 137);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 190);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(42, 20);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time";
            // 
            // lblCharges
            // 
            this.lblCharges.AutoSize = true;
            this.lblCharges.Location = new System.Drawing.Point(12, 243);
            this.lblCharges.Name = "lblCharges";
            this.lblCharges.Size = new System.Drawing.Size(138, 20);
            this.lblCharges.TabIndex = 6;
            this.lblCharges.Text = "Class Charges (RM):";
            this.lblCharges.Click += new System.EventHandler(this.lblCharges_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(459, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Class";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(12, 160);
            this.txtDate.Mask = "00/00/0000";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(205, 27);
            this.txtDate.TabIndex = 10;
            this.txtDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(12, 213);
            this.txtTime.Mask = "00:00";
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(205, 27);
            this.txtTime.TabIndex = 11;
            this.txtTime.ValidatingType = typeof(System.DateTime);
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.Location = new System.Drawing.Point(308, 163);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(50, 20);
            this.lblTutor.TabIndex = 12;
            this.lblTutor.Text = "label1";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 300);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(456, 163);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lbl50
            // 
            this.lbl50.AutoSize = true;
            this.lbl50.Location = new System.Drawing.Point(12, 263);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(25, 20);
            this.lbl50.TabIndex = 14;
            this.lbl50.Text = "50";
            this.lbl50.Click += new System.EventHandler(this.lbl50_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 510);
            this.Controls.Add(this.lbl50);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblTutor);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCharges);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPlease);
            this.Controls.Add(this.cmbClass);
            this.Name = "Form3";
            this.Text = "Add Class Infomation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbClass;
        private Label lblPlease;
        private Label lblDate;
        private Label lblTime;
        private Label lblCharges;
        private Button button1;
        private MaskedTextBox txtDate;
        private MaskedTextBox txtTime;
        private Label lblTutor;
        private ListView listView1;
        private Label lbl50;
    }
}