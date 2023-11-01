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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string stat; 
            User obj1 = new User(txtUsername.Text, txtPassword.Text);
            stat = obj1.login(txtUsername.Text);
            if (stat != null)
            {
                MessageBox.Show(stat);
            }
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }
    }
}
