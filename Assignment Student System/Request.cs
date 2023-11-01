using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Student_System
{
    internal class Request
    {
        private int requestID;
        private string studName;
        private string newSub;
        public Request(int i, string n, string s) 
        { 
            requestID = i; 
            studName = n; 
            newSub = s; 
        }

        public string updateRequest()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            // set the new subject value to the same column in the student table
            SqlCommand cmd2 = new SqlCommand("update students set studentSubject = @newSub from students join request on studentName = req_stud_name where studentName = @studName and studentSubject = current_subject", con);
            cmd2.Parameters.AddWithValue("@newsub", newSub);
            cmd2.Parameters.AddWithValue("@studName", studName);
            int i = Convert.ToInt32(cmd2.ExecuteNonQuery());
          
            string status;
            if (i != 0)
            {
                status = "Update succeed.";
                // set the pending request to approved
                SqlCommand cmd1 = new SqlCommand("update request set req_status = 'approved' where Id= @id", con);
                cmd1.Parameters.AddWithValue("@id", requestID);
                cmd1.ExecuteNonQuery();
            }
            else
            {
                status = "Update failed.";
            }
            con.Close();
            return status;
        }

    }
}
