namespace Assignment_Student_System
{
    partial class StuClassSchedule
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
            this.lblClassSche = new System.Windows.Forms.Label();
            this.rbnForm1 = new System.Windows.Forms.RadioButton();
            this.rbnForm2 = new System.Windows.Forms.RadioButton();
            this.rbnForm3 = new System.Windows.Forms.RadioButton();
            this.rbnForm4 = new System.Windows.Forms.RadioButton();
            this.rbnForm5 = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstSchedule = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblClassSche
            // 
            this.lblClassSche.AutoSize = true;
            this.lblClassSche.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClassSche.Location = new System.Drawing.Point(193, 33);
            this.lblClassSche.Name = "lblClassSche";
            this.lblClassSche.Size = new System.Drawing.Size(262, 46);
            this.lblClassSche.TabIndex = 0;
            this.lblClassSche.Text = "Class Schedule";
            // 
            // rbnForm1
            // 
            this.rbnForm1.AutoSize = true;
            this.rbnForm1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbnForm1.Location = new System.Drawing.Point(26, 117);
            this.rbnForm1.Name = "rbnForm1";
            this.rbnForm1.Size = new System.Drawing.Size(120, 37);
            this.rbnForm1.TabIndex = 1;
            this.rbnForm1.TabStop = true;
            this.rbnForm1.Text = "Form 1";
            this.rbnForm1.UseVisualStyleBackColor = true;
            this.rbnForm1.CheckedChanged += new System.EventHandler(this.rbnForm1_CheckedChanged);
            // 
            // rbnForm2
            // 
            this.rbnForm2.AutoSize = true;
            this.rbnForm2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbnForm2.Location = new System.Drawing.Point(26, 180);
            this.rbnForm2.Name = "rbnForm2";
            this.rbnForm2.Size = new System.Drawing.Size(120, 37);
            this.rbnForm2.TabIndex = 2;
            this.rbnForm2.TabStop = true;
            this.rbnForm2.Text = "Form 2";
            this.rbnForm2.UseVisualStyleBackColor = true;
            this.rbnForm2.CheckedChanged += new System.EventHandler(this.rbnForm2_CheckedChanged);
            // 
            // rbnForm3
            // 
            this.rbnForm3.AutoSize = true;
            this.rbnForm3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbnForm3.Location = new System.Drawing.Point(26, 245);
            this.rbnForm3.Name = "rbnForm3";
            this.rbnForm3.Size = new System.Drawing.Size(120, 37);
            this.rbnForm3.TabIndex = 3;
            this.rbnForm3.TabStop = true;
            this.rbnForm3.Text = "Form 3";
            this.rbnForm3.UseVisualStyleBackColor = true;
            this.rbnForm3.CheckedChanged += new System.EventHandler(this.rbnForm3_CheckedChanged);
            // 
            // rbnForm4
            // 
            this.rbnForm4.AutoSize = true;
            this.rbnForm4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbnForm4.Location = new System.Drawing.Point(26, 310);
            this.rbnForm4.Name = "rbnForm4";
            this.rbnForm4.Size = new System.Drawing.Size(120, 37);
            this.rbnForm4.TabIndex = 4;
            this.rbnForm4.TabStop = true;
            this.rbnForm4.Text = "Form 4";
            this.rbnForm4.UseVisualStyleBackColor = true;
            this.rbnForm4.CheckedChanged += new System.EventHandler(this.rbnForm4_CheckedChanged);
            // 
            // rbnForm5
            // 
            this.rbnForm5.AutoSize = true;
            this.rbnForm5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbnForm5.Location = new System.Drawing.Point(26, 373);
            this.rbnForm5.Name = "rbnForm5";
            this.rbnForm5.Size = new System.Drawing.Size(120, 37);
            this.rbnForm5.TabIndex = 5;
            this.rbnForm5.TabStop = true;
            this.rbnForm5.Text = "Form 5";
            this.rbnForm5.UseVisualStyleBackColor = true;
            this.rbnForm5.CheckedChanged += new System.EventHandler(this.rbnForm5_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(482, 438);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 35);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstSchedule
            // 
            this.lstSchedule.FormattingEnabled = true;
            this.lstSchedule.ItemHeight = 25;
            this.lstSchedule.Location = new System.Drawing.Point(181, 117);
            this.lstSchedule.Name = "lstSchedule";
            this.lstSchedule.Size = new System.Drawing.Size(420, 304);
            this.lstSchedule.TabIndex = 24;
            // 
            // StuClassSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 490);
            this.Controls.Add(this.lstSchedule);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rbnForm5);
            this.Controls.Add(this.rbnForm4);
            this.Controls.Add(this.rbnForm3);
            this.Controls.Add(this.rbnForm2);
            this.Controls.Add(this.rbnForm1);
            this.Controls.Add(this.lblClassSche);
            this.Name = "StuClassSchedule";
            this.Text = "StuClassSchedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblClassSche;
        private RadioButton rbnForm1;
        private RadioButton rbnForm2;
        private RadioButton rbnForm3;
        private RadioButton rbnForm4;
        private RadioButton rbnForm5;
        private Button btnBack;
        private ListBox lstSchedule;
    }
}