using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment_Student_System
{
    public partial class StuUpdateProfile : Form
    {
        public static string? studname;
        public StuUpdateProfile()
        {
            InitializeComponent();
        }
        public StuUpdateProfile(string sn)
        {
            InitializeComponent();
            studname = sn;
        }

        private void StuUpdateProfile_Load(object sender, EventArgs e)
        {
            Student obj1 = new Student(studname);
            Student.viewProfile(obj1);

            txtEmail.Text = obj1.Email;
            txtConNum.Text = obj1.PhoneNum;
            txtPassword.Text = obj1.Password;
            lblStuName.Text = obj1.StudName;
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Student obj1 = new Student(studname);
                MessageBox.Show(obj1.updateProfile(txtEmail.Text, txtConNum.Text, txtPassword.Text));

                this.Close();
            }
            else if(result == DialogResult.No)
            {
                MessageBox.Show("Action Discharged.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Action Discharged.");
            }
        }
    }
}
