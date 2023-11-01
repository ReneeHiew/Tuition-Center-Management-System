namespace Assignment_Student_System
{
    partial class Form2
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblTutor = new System.Windows.Forms.Label();
            this.dgvAllData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(11, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(357, 50);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome Tutor";
            this.lblWelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(661, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Class Infomation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(10, 280);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(661, 35);
            this.btnViewAll.TabIndex = 3;
            this.btnViewAll.Text = "View/Refresh All My Class";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(661, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete Class Information";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(14, 103);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(661, 36);
            this.button5.TabIndex = 7;
            this.button5.Text = "Update Class Information";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTutor.Location = new System.Drawing.Point(375, 9);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(155, 50);
            this.lblTutor.TabIndex = 8;
            this.lblTutor.Text = "label1";
            this.lblTutor.Click += new System.EventHandler(this.lblTutor_Click);
            // 
            // dgvAllData
            // 
            this.dgvAllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllData.Location = new System.Drawing.Point(14, 321);
            this.dgvAllData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAllData.Name = "dgvAllData";
            this.dgvAllData.RowHeadersWidth = 51;
            this.dgvAllData.RowTemplate.Height = 25;
            this.dgvAllData.Size = new System.Drawing.Size(658, 148);
            this.dgvAllData.TabIndex = 9;
            this.dgvAllData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 485);
            this.Controls.Add(this.dgvAllData);
            this.Controls.Add(this.lblTutor);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblWelcome;
        private Button button1;
        private Button btnVlewAll;
        private Button button2;
        private Button button5;
        private Label lblTutor;
        private DataGridView dataGridView1;
        private DataGridView dgvAllData;
        private Button btnViewAll;
    }
}