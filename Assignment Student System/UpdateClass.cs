using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Student_System
{
    public partial class UpdateClass : Form
    {
        private string selectedSubject;
        private string TutorName;
        public UpdateClass()
        {
            InitializeComponent();
        }
        public UpdateClass(string TN)
        {
            InitializeComponent();
            TutorName= TN;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Visible= false;
        }

        private void txtDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void UpdateClass_Load(object sender, EventArgs e)
        {
            btnConfirm.Enabled = true;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT DISTINCT Subject_Name FROM classes WHERE Tutor_Name = @A", con);
            sqlCommand.Parameters.AddWithValue("@A", TutorName);
            SqlDataReader RAD = sqlCommand.ExecuteReader();
            ArrayList subList = new ArrayList();
            while (RAD.Read())
            {
                string name = RAD.GetString(0);
                subList.Add(name);
            }
            RAD.Close();
            con.Close();

            foreach (string sname in subList)
            {
                lstSubject.Items.Add(sname);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (lstSubject.SelectedItem == null)
            {
                MessageBox.Show("No data selected");
                return;
            }
            selectedSubject = lstSubject.SelectedItem.ToString();
            lblSubjectOutput.Text = selectedSubject;
            lstSubject.Items.Clear();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("select Date, Time from classes WHERE Tutor_Name = @tutorName AND Subject_Name = @subjectName", con);
            sqlCommand.Parameters.AddWithValue("@tutorName", TutorName);
            sqlCommand.Parameters.AddWithValue("@subjectName", selectedSubject);
            SqlDataReader RAD = sqlCommand.ExecuteReader();
            while (RAD.Read())
            {
                string date = RAD.GetString(0);
                string time = RAD.GetString(1);
                lstSubject.Items.Add(string.Format("{0} - {1}", date, time));
            }
            RAD.Close();
            con.Close();
            btnConfirm.Enabled = false;
        }

        private void lstSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSubject.SelectedIndex >= 0)
            {
                string[] selectedDateTime = lstSubject.SelectedItem.ToString().Split('-');
                if (selectedDateTime.Length == 2)
                {
                    txtDate.Text = selectedDateTime[0].Trim();
                    txtTime.Text = selectedDateTime[1].Trim();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("update classes set Date = @d, Time =@t where Tutor_Name = @n and Subject_Name = @s" , con);
            sqlCommand.Parameters.AddWithValue("@d", txtDate.Text);
            sqlCommand.Parameters.AddWithValue("@t", txtTime.Text);
            sqlCommand.Parameters.AddWithValue("@n", TutorName);
            sqlCommand.Parameters.AddWithValue("@s", selectedSubject);
            sqlCommand.ExecuteNonQuery();
            con.Close();
            btnUpdate.Enabled = false;
        }
    }
}
