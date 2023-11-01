using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Student_System
{
    internal class Receptionist
    {
        private string rcpUsername; //rcp stands for: receptionist

        private string rcpMail;
        private string rcpName;
        private string rcpIC;
        private string rcpGender;
        private string rcpCountry;
        private string rcpAddress;
        private string rcpContact;
        private string rcpPassword; //get from user table

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Receptionist(string un) 
        { 
            rcpUsername = un; 
        }

        public string RcpMail { get => rcpMail; set => rcpMail = value; }
        public string RcpPassword { get => rcpPassword; set => rcpPassword = value; }
        public string RcpContact { get => rcpContact; set => rcpContact = value; }
        public string RcpIC { get => rcpIC; set => rcpIC = value; }
        public string RcpGender { get => rcpGender; set => rcpGender = value; }
        public string RcpCountry { get => rcpCountry; set => rcpCountry = value; }
        public string RcpAddress { get => rcpAddress; set => rcpAddress = value; }
        public string RcpName { get => rcpName; set => rcpName = value; }

        public static void viewrcpProfile(Receptionist o1) //pass value called by object by this class initally, pass object so can call the variable below
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from receptionist where Username = @a", con);
            SqlCommand cmd2 = new SqlCommand("select * from users where username = @b", con);
            cmd1.Parameters.AddWithValue("@a", o1.rcpUsername);
            cmd2.Parameters.AddWithValue("@b", o1.rcpUsername);

            using (SqlDataReader rd1 = cmd1.ExecuteReader())
            {
                while (rd1.Read())
                {
                    o1.rcpName = rd1.GetString(2);
                    o1.rcpCountry = rd1.GetString(3);
                    o1.rcpIC = rd1.GetString(4);
                    o1.rcpGender = rd1.GetString(5);
                    o1.rcpMail = rd1.GetString(6);
                    o1.rcpContact = rd1.GetString(7);
                    o1.rcpAddress = rd1.GetString(8);
                }
            }

            using (SqlDataReader rd2 = cmd2.ExecuteReader())
            {
                if (rd2.Read())
                {
                    o1.rcpPassword = rd2.GetString(2);
                }
            }

            con.Close();
        }

        public string updatercpProfile(string ad, string em, string cn, string pw)
        {
            string status;
            con.Open();
            rcpAddress = ad;
            rcpMail = em;
            rcpContact = cn;
            rcpPassword = pw;

            SqlCommand cmd1 = new SqlCommand("update receptionist set Address = @addr, Email = @mail, Phone = @num where Username = @name", con);
            cmd1.Parameters.AddWithValue("@addr", rcpAddress);
            cmd1.Parameters.AddWithValue("@mail", rcpMail);
            cmd1.Parameters.AddWithValue("@num", rcpContact);
            cmd1.Parameters.AddWithValue("@name", rcpUsername);

            SqlCommand cmd2 = new SqlCommand("update users set password = @pw where username =@name", con);
            cmd2.Parameters.AddWithValue("@pw", rcpPassword);
            cmd2.Parameters.AddWithValue("@name", rcpUsername);

            int i = cmd1.ExecuteNonQuery();
            int j = cmd2.ExecuteNonQuery();
            if (i != 0 || j != 0)
            {
                status = "Update Successful";
            }
            else
            {
                status = "Update Fail";
            }
            con.Close();

            return status;
        }

    }
}
