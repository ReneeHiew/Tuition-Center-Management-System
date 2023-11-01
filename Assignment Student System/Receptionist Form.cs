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
    public partial class frmReceptionPage : Form
    {
        private static string Username;// input from the login is pass to here and can be stored in this variable other pages as well

        public frmReceptionPage()
        {
            InitializeComponent();
        }

        public frmReceptionPage(string un)
        {
            InitializeComponent();
            Username = un;

            lblWelcomeTitle.Text = "Welcome back, " + Username;
        }

        private void btnRegistration_Page_Click(object sender, EventArgs e)
        {
            frmRegistrationPage regisp = new frmRegistrationPage();
            regisp.ShowDialog();
        }

        private void btnUpdateSubject_Page_Click(object sender, EventArgs e)
        {
            frmUpdateSub updateSubp = new frmUpdateSub();
            updateSubp.ShowDialog();
        }

        private void btnPayment_Page_Click(object sender, EventArgs e)
        {
            frmPayment paymentp = new frmPayment();
            paymentp.ShowDialog();
        }

        private void btnDltStudent_Page_Click(object sender, EventArgs e)
        {
            frmDltStudentPage dltStudp = new frmDltStudentPage();
            dltStudp.ShowDialog();
        }

        private void btnUpdateProfile_Page_Click(object sender, EventArgs e)
        {
            frmReceptionistProfile rcpProfilep = new frmReceptionistProfile(Username);
            rcpProfilep.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
