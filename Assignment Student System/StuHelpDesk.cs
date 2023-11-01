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
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment_Student_System
{
    public partial class StuHelpDesk : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        private string studname;
        public static string? studRequest;
        private string currentSubject;
        private string newSubject; 

        public DialogResult result 
        { 
            get; private set; 
        }

        public StuHelpDesk()
        {
            InitializeComponent();
        }
        public StuHelpDesk(string sn)
        {
            InitializeComponent();
            studname = sn;
        }

        private void StuHelpDesk_Load(object sender, EventArgs e)
        {
            Student obj1 = new Student(studname);
            Student.viewProfile(obj1);

            con.Open();
            SqlCommand cmd1 = new SqlCommand("select studentSubject from students where studentName = @a", con);
            cmd1.Parameters.AddWithValue("@a", studname);
            SqlDataReader read1 = cmd1.ExecuteReader();
            while (read1.Read())
            {
                string value = read1.GetString(0);
                cmbCurrentSub.Items.Add(value);
            }
            read1.Close();

            SqlCommand cmd2 = new SqlCommand("select subject_name from subject where subject_name not in (select studentSubject from students where studentName = @b)", con);
            cmd2.Parameters.AddWithValue("@b", studname);
            SqlDataReader read2 = cmd2.ExecuteReader();
            while(read2.Read())
            {
                string value = read2.GetString(0);
                cmbNewSub.Items.Add(value);
            }
            read2.Close();
            con.Close();

            txtStuName.Text = studname;

            ArrayList req = new ArrayList();
            Student stuReq = new Student(studname);
            req = stuReq.viewRequest(studname);

            foreach (var item in req)
            {
                PendingRequest.Items.Add(item);
            }
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            currentSubject = cmbCurrentSub.SelectedItem.ToString(); 
            newSubject = cmbNewSub.SelectedItem.ToString(); 

            DialogResult result = MessageBox.Show("Do you wish to continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Student obj1 = new Student(txtStuName.Text, newSubject, currentSubject); 
                MessageBox.Show(obj1.addRequest());

                this.Close();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Action Discharged.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();

            DialogResult result = MessageBox.Show("Do you wish to continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                if (PendingRequest.SelectedItem != null)
                {
                    string selectedItem = PendingRequest.SelectedItem.ToString();

                    SqlCommand cmd = new SqlCommand("delete from request where req_stud_name = @n and req_status ='pending'", con);
                    cmd.Parameters.AddWithValue("@n", studname);
                    cmd.ExecuteNonQuery();

                    PendingRequest.Items.Remove(selectedItem);
                }
                else
                {
                    MessageBox.Show("Please select the request to delete", "title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Action Discharged.");
            }
            con.Close();
        }

        private void cmbCurrentSub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
