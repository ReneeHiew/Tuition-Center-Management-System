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
    public partial class StudentHome : Form
    {
        public static string? name;
        public StudentHome()
        {
            InitializeComponent();
        }
        public StudentHome(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void StudentHome_Load(object sender, EventArgs e)
        {
            lblStuName.Text = name;
        }

        private void btnClassSchedule_Click(object sender, EventArgs e)
        {
            StuClassSchedule cs = new StuClassSchedule();
            cs.ShowDialog();
        }

        private void btnHelpDesk_Click(object sender, EventArgs e)
        {
            StuHelpDesk hd = new StuHelpDesk(name);
            hd.ShowDialog();
        }

        private void btnStuProfile_Click(object sender, EventArgs e)
        {
            StuProfile sp = new StuProfile(name);
            sp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to log out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
