using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment_Student_System
{
    public partial class StuProfile : Form
    {
        public static string? studname;
        public StuProfile()
        {
            InitializeComponent();
        }
        public StuProfile(string n)
        {
            InitializeComponent();
            studname = n;
        }

        private void StuProfile_Load(object sender, EventArgs e)
        {
            Student obj1 = new Student(studname);
            Student.viewProfile(obj1);

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd1 = new SqlCommand("select studentSubject from students where studentName = @a", con);
            cmd1.Parameters.AddWithValue("@a", studname);
            SqlDataReader rd = cmd1.ExecuteReader();
            while (rd.Read())
            {
                string subs = rd.GetString(0);
                lstSubjects.Items.Add(subs);
            }
            con.Close();

            lblStuName.Text = studname;
            lblStudentEmail2.Text = obj1.Email;
            lblStudentNum2.Text = obj1.PhoneNum;
            lblPassword2.Text = obj1.Password;
            lblStudentForm2.Text = obj1.studentClass;
            lblStuIC2.Text = obj1.studentIC;
            lblStuAdd.Text = obj1.studentAddress;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            StuUpdateProfile up = new StuUpdateProfile(studname);
            up.ShowDialog();
        }
    }
}
