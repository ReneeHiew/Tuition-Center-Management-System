using System;
using System.Collections;
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
    public partial class frmDltStudentPage : Form
    {
        public frmDltStudentPage()
        {
            InitializeComponent();
        }

        private void frmDltStudentPage_Load(object sender, EventArgs e)
        {
            ArrayList studentNames = new ArrayList();
            studentNames = Student.viewStudents();
            foreach (var item in studentNames)
            {
                lstStudents.Items.Add(item);
            }
        }

        private void chkConfirmDlt_CheckedChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = chkConfirmDlt.Checked;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (chkConfirmDlt.Checked)
            {
                string dltName = lstStudents.SelectedItem.ToString();
                Student obj1 = new Student(dltName);

                string dltStatus = obj1.dltStudent();
                string dltTitle = "Delete Status";
                MessageBox.Show(dltStatus, dltTitle);
 
            }
            else
            {
                MessageBox.Show("Please check the checkbox before confirming the delete");
            }
            
        }

        private void btnBack_studystatus_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
