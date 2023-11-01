using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Assignment_Student_System
{
    public partial class frmPayment : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            FilldgvPayment();
        }

        private void FilldgvPayment()
        {
            con.Open();
            string cmd1 = "select Id as 'ID', studName_payment as 'Name', level_payment as 'Level', subject_payment as 'Subject', totalFee_payment as 'Fee (RM)', month_payment as 'Month', status_payment as 'Status' from payment";
            SqlDataAdapter da = new SqlDataAdapter(cmd1, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPayment.DataSource = dt;
            con.Close();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            // Check for whether the payment has approved
            DataGridViewRow selected = dgvPayment.CurrentRow;
            string requestStatus = (string)selected.Cells[6].Value;
            if (requestStatus == "approved")
            {
                MessageBox.Show("The payment has already been approved.");
                dgvPayment.ClearSelection();
            }

            con.Open();
            // Clear the selection if there is multiple row selected and the student names are different
            if (dgvPayment.SelectedRows.Count >= 1)
            {
                string studName = dgvPayment.SelectedRows[0].Cells[1].Value.ToString();
                string levelpay = dgvPayment.SelectedRows[0].Cells[2].Value.ToString();
                string monthPay = dgvPayment.SelectedRows[0].Cells[5].Value.ToString();

                bool allSame = true;

                foreach (DataGridViewRow row in dgvPayment.SelectedRows)
                {
                    if (row.Cells[1].Value.ToString() != studName || row.Cells[5].Value.ToString() != monthPay)
                    {
                        allSame = false;
                        break;
                    }
                }

                if (allSame)
                {
                    SqlCommand cmd1 = new SqlCommand("update payment set status_payment = 'approved' where studName_payment = @name and month_payment = @month", con);
                    cmd1.Parameters.AddWithValue("@month", monthPay);
                    cmd1.Parameters.AddWithValue("@name", studName);
                    cmd1.ExecuteNonQuery();

                    // Get values from the selected rows and show them in a message box as receipt
                    List<string> subjectsPay = new List<string>();
                    decimal totalFee = 0;
                    foreach (DataGridViewRow rows in dgvPayment.SelectedRows)
                    {
                        string subject = rows.Cells[3].Value.ToString();
                        subjectsPay.Add(subject);

                        decimal fee = Convert.ToDecimal(rows.Cells[4].Value);
                        totalFee += fee;
                    }
                    string receipt = "Student Name: " + studName + "\nLevel: " + levelpay + "\nSubjects: " + string.Join(", ", subjectsPay) + "\nTotal Fee: " + totalFee.ToString("C") + "\nMonth of: " + monthPay;
                    string title = "Student Receipt";
                    MessageBox.Show(receipt, title);
                }
                else
                {
                    MessageBox.Show("Please select students with the same name and same month.", "Error");
                    dgvPayment.ClearSelection();
                }
            }

            con.Close();
        }

        private void btnBack_payment_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
