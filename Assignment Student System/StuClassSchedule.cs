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

namespace Assignment_Student_System
{
    public partial class StuClassSchedule : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        string classlvl;
        public StuClassSchedule()
        {
            InitializeComponent();
        }
        public StuClassSchedule(string cl)
        {
            InitializeComponent();
            classlvl = cl;
        }

        private void rbnForm1_CheckedChanged(object sender, EventArgs e)
        {
            lstSchedule.Items.Clear();
            ArrayList schedule1 = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Subject_Name, Date, Time from classes where Class_Level = 'Form 1'", con);
            SqlDataReader rd = cmd.ExecuteReader();

            while(rd.Read())
            {
                string classSch = rd["Subject_Name"] + " | Date: " + rd["Date"] + " | Time: " + rd["Time"];
                schedule1.Add(classSch);
            }

            foreach (var item in schedule1)
            {
                lstSchedule.Items.Add(item);
            }
            rd.Close();
            con.Close();
        }

        private void rbnForm2_CheckedChanged(object sender, EventArgs e)
        {
            lstSchedule.Items.Clear();
            ArrayList schedule2 = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Subject_Name, Date, Time from classes where Class_Level = 'Form 2'", con);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string classSch = rd["Subject_Name"] + " | Date: " + rd["Date"] + " | Time: " + rd["Time"];
                schedule2.Add(classSch);
            }

            foreach (var item in schedule2)
            {
                lstSchedule.Items.Add(item);
            }
            rd.Close();
            con.Close();
        }

        private void rbnForm3_CheckedChanged(object sender, EventArgs e)
        {
            lstSchedule.Items.Clear();
            ArrayList schedule3 = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Subject_Name, Date, Time from classes where Class_Level = 'Form 3'", con);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string classSch = rd["Subject_Name"] + " | Date: " + rd["Date"] + " | Time: " + rd["Time"];
                schedule3.Add(classSch);
            }

            foreach (var item in schedule3)
            {
                lstSchedule.Items.Add(item);
            }
            rd.Close();
            con.Close();
        }

        private void rbnForm4_CheckedChanged(object sender, EventArgs e)
        {
            lstSchedule.Items.Clear();
            ArrayList schedule4 = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Subject_Name, Date, Time from classes where Class_Level = 'Form 4'", con);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string classSch = rd["Subject_Name"] + " | Date: " + rd["Date"] + " | Time: " + rd["Time"];
                schedule4.Add(classSch);
            }

            foreach (var item in schedule4)
            {
                lstSchedule.Items.Add(item);
            }
            rd.Close();
            con.Close();
        }

        private void rbnForm5_CheckedChanged(object sender, EventArgs e)
        {
            lstSchedule.Items.Clear();
            ArrayList schedule5 = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Subject_Name, Date, Time from classes where Class_Level = 'Form 5'", con);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string classSch = rd["Subject_Name"] + " | Date: " + rd["Date"] + " | Time: " + rd["Time"];
                schedule5.Add(classSch);
            }

            foreach (var item in schedule5)
            {
                lstSchedule.Items.Add(item);
            }
            rd.Close();
            con.Close();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
