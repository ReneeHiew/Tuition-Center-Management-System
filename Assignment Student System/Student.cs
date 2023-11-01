using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment_Student_System
{
    internal class Student
    {
        private string studName;
        private string email;
        private string phoneNum;
        private string studRequest;
        private string studCurrentSub; 
        private string enrollMonth;
        private List<string> subNameList;
        private string password;
        public string studentClass;
        public string studentSubject;
        public string studentID;
        public string studentIC;
        public string studentAddress;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Email { get => email; set => email = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Password { get => password; set => password = value; }
        public string StudName { get => studName; set => studName = value; }

        public Student(string sn) 
        {
            studName = sn;
        }

        public Student(string sn, string rq, string sb)
        {
            studName = sn;
            studRequest = rq;
            studCurrentSub = sb;
        }

        public Student (string sn, string ic, string em, string pn, string ad, string lv, string m, List<string> sl)
        {
            studName = sn;
            studentIC = ic;
            email= em;
            phoneNum = pn;
            studentAddress = ad;
            studentClass = lv;
            enrollMonth = m;
            subNameList = sl;
        }

        public string addRequest()
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("Insert into request(req_stud_name, new_subject, current_subject, req_status) values(@name, @rq, @sub, 'pending')", con);
            cmd.Parameters.AddWithValue("@name", studName);
            cmd.Parameters.AddWithValue("@rq", studRequest);
            cmd.Parameters.AddWithValue("@sub", studCurrentSub);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Request Successful.";
            else
                status = "Request Failed.";

            con.Close();
            return status;
        }

        public static void viewProfile(Student o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from students where studentName ='" + o1.studName + "'", con); 

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.Email = rd.GetString(2);
                o1.PhoneNum = rd.GetString(3);
                o1.Password = rd.GetString(4);
                o1.studentClass = rd.GetString(5);
                o1.studentIC = rd.GetString(7);
                o1.studentAddress = rd.GetString(8);
            }
            con.Close();
        }

        public ArrayList viewRequest(string studName)
        {
            ArrayList request = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select current_subject, new_subject from request where req_stud_name ='" + studName + "' and req_status = 'pending'", con); 
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string requestSubChanges = rd["current_subject"] + "->" + rd["new_subject"];
                request.Add(requestSubChanges);
            }
            con.Close();
            return request;
        }

        public string updateProfile(string em, string pn, string pw)
        {
            string status;
            con.Open();

            email = em;
            phoneNum = pn;
            password = pw;

            SqlCommand cmd = new SqlCommand("update students set email ='" + email + "', phoneNumber ='" + phoneNum + "', password ='" + password + "' where studentName ='" + studName + "'", con);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Update Failed.";

            con.Close();

            return status;
        }

        public string registerStudent()
        {
            string status;
            con.Open();

            foreach (var item in subNameList)
            {
                SqlCommand cmd1 = new SqlCommand("insert into students (studentName, studentIC, email, phoneNumber, password, studentAddress, studentClass, enroll_month, studentSubject) values (@name, @ic, @mail, @num, 'stu123', @addr, @lvl, @month, @sub)", con);

                cmd1.Parameters.AddWithValue("@name", studName);
                cmd1.Parameters.AddWithValue("@ic", studentIC);
                cmd1.Parameters.AddWithValue("@mail", email);
                cmd1.Parameters.AddWithValue("@num", phoneNum);
                cmd1.Parameters.AddWithValue("@addr", studentAddress);
                cmd1.Parameters.AddWithValue("@lvl", studentClass);
                cmd1.Parameters.AddWithValue("@month", enrollMonth);
                cmd1.Parameters.AddWithValue("@sub", item);

                cmd1.ExecuteNonQuery();
            }

            SqlCommand cmd2 = new SqlCommand("insert into users (username, password, role) values (@name, 'stu123', 'student')", con);
            cmd2.Parameters.AddWithValue("@name", studName);
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("select count (*) from students where studentName = @a", con);
            cmd3.Parameters.AddWithValue("@a", studName);

            int count = subNameList.Count;

            int s = Convert.ToInt32(cmd3.ExecuteScalar());
            if (count == s)
            {
                status = "Registration Succesful.";
            }
            else
            {
                status = "Registartion NOT Succesful.";
            }
            con.Close();
            return status;
        }

        public static ArrayList viewStudents()
        {
            ArrayList names = new ArrayList();
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select username from users where role = 'student'", con);
            SqlDataReader rd = cmd1.ExecuteReader();
            while (rd.Read())
            {
                names.Add(rd.GetString(0));
            }
            con.Close();
            return names;
        }

        public string dltStudent()
        {
            string status;

            con.Open();
            SqlCommand cmd1 = new SqlCommand("delete from users where username = @name", con);
            cmd1.Parameters.AddWithValue("@name", studName);

            SqlCommand cmd2 = new SqlCommand("delete from students where studentName = @name", con);
            cmd2.Parameters.AddWithValue("@name", studName);

            SqlCommand cmd3 = new SqlCommand("delete from request where req_stud_name = @name", con);
            cmd3.Parameters.AddWithValue("@name", studName);

            SqlCommand cmd4 = new SqlCommand("delete from payment where studName_payment = @name", con);
            cmd4.Parameters.AddWithValue("@name", studName);

            int dlt1 = cmd1.ExecuteNonQuery();
            int dlt2 = cmd2.ExecuteNonQuery();
            int dlt3 = cmd3.ExecuteNonQuery();
            int dlt4 = cmd4.ExecuteNonQuery();

            if (dlt1 != 0 || dlt2 != 0 || dlt3 != 0 || dlt4 != 0)
            {
                status = "All record of the student has been succesfully deleted";
            }
            else
            {
                status = "Fail to delete student record";
            }
            con.Close();
            return status;
        }
    }
}
