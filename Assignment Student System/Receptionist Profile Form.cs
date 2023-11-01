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
    public partial class frmReceptionistProfile : Form
    {
        public static string rcpUsername;
        public frmReceptionistProfile()
        {
            InitializeComponent();
        }
        public frmReceptionistProfile(string un)
        {
            InitializeComponent();
            rcpUsername = un;
        }

        private void frmReceptionistProfile_Load(object sender, EventArgs e)
        {
            //obtain values from receptionist table through Receptionist class' viewrcpProfile
            Receptionist obj1 = new Receptionist(rcpUsername);
            Receptionist.viewrcpProfile(obj1);

            //display all the values obtain in their respective label and textbox
            lblName_Out.Text = obj1.RcpName;
            lblIC_Out.Text = obj1.RcpIC;
            lblGender_Out.Text= obj1.RcpGender;
            lblCountry_Out.Text= obj1.RcpCountry;
            txtAddress.Text = obj1.RcpAddress;
            txtContactNum.Text = obj1.RcpContact;
            txtEmail.Text = obj1.RcpMail;
            lblUsername_Out.Text = rcpUsername;
            txtPassword.Text = obj1.RcpPassword;
        }
        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Receptionist obj1 = new Receptionist(rcpUsername);
            MessageBox.Show(obj1.updatercpProfile(txtAddress.Text, txtEmail.Text, txtContactNum.Text, txtPassword.Text));
        }

        private void btnBack_receptionistprofilepage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}