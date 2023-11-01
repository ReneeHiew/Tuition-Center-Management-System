using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Student_System
{
    internal class User
    {
        private string Username;
        private string Password;

        public User(string un, string pd) 
        {
            Username = un;
            Password = pd;
        }

        public string login(string un)
        {
            string? status = null;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from users where username=@u and password=@p", con);
            cmd.Parameters.AddWithValue("@u", Username);
            cmd.Parameters.AddWithValue("@p", Password);

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select role from users where username =@u and password =@p", con);
                cmd2.Parameters.AddWithValue("@u", Username);
                cmd2.Parameters.AddWithValue("@p", Password);

                string userRole = cmd2.ExecuteScalar().ToString();

                if (userRole == "admin")
                {
                    Admin a = new Admin(un);
                    a.ShowDialog();
                }
                else if (userRole == "student")
                {
                    StudentHome s = new StudentHome(un);
                    s.ShowDialog();
                }
                else if (userRole == "receptionist")
                {
                    frmReceptionPage r = new frmReceptionPage(un);
                    r.ShowDialog();
                }
                else if (userRole == "tutor")
                {
                    Form2 t = new Form2(un);
                    t.ShowDialog();
                }
            }
            else
                status = "Incorrect username or password. Please try again.";
            con.Close();

            return status;
        }
    }
}
