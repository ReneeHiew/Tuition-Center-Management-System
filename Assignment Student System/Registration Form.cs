using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Student_System
{
    public partial class frmRegistrationPage : Form
    {
        public frmRegistrationPage()
        {
            InitializeComponent();
        }

        private void btnConfirmRegis_Click(object sender, EventArgs e)
        {
            string stat;
            string level = cmbLevel.SelectedItem.ToString();
            string enrolledMonth = cmbEnrollMonth.SelectedItem.ToString();
            List<string> selectedSubjects = new List<string>();
            if (chkMath.Checked) { selectedSubjects.Add(chkMath.Text); }
            if (chkSci.Checked) { selectedSubjects.Add(chkSci.Text); }
            if (chkEng.Checked) { selectedSubjects.Add(chkEng.Text);}

            Student obj1 = new Student(txtStudentName.Text, txtIC.Text, txtEmail.Text, txtContactNum.Text, txtAddress.Text, level, enrolledMonth, selectedSubjects);
            stat = obj1.registerStudent();
            MessageBox.Show(stat);
        }

        private void btnCancelRegis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
