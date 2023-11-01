using System;
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
    public partial class frmUpdateSub : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public frmUpdateSub()
        {
            InitializeComponent();
        }

        private void frmUpdateSub_Load(object sender, EventArgs e)
        {
            FilldgvRequest();
        }

        private void FilldgvRequest()
        {
            con.Open();
            string cmd1 = "select Id as 'ID', req_stud_name as 'Student Name', current_subject as 'Current Subject', new_subject as 'New Subject', req_status as 'Status' from request";
            SqlDataAdapter da = new SqlDataAdapter(cmd1, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRequest.DataSource = dt;
            con.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvRequest.CurrentRow;
            string requestStatus = (string)selected.Cells[4].Value;
            // message for receptionist when the request has been approved
            if (requestStatus == "approved")
            {
                MessageBox.Show("The request has been approved.");
                dgvRequest.ClearSelection();
            }
            else if (dgvRequest.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgvRequest.CurrentRow;
                // lesson learned: dont put column name in the [] bracket, put the INDEX value fo the column
                int requestID =(int)selectedRow.Cells[0].Value; //gets the id value of the selected row
                string studName = (string)selectedRow.Cells[1].Value; //gets the student name of the selected row
                string newSub = (string)selectedRow.Cells[3].Value; //gets the new subject name of the selected row

                Request obj1 = new Request(requestID, studName, newSub);
                string stat = obj1.updateRequest();
                MessageBox.Show(stat);
            }
            else
            {
                MessageBox.Show("Please choose ONE request to approve.");
                dgvRequest.ClearSelection();
            }
        }

        private void btnBack_updatesub_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
