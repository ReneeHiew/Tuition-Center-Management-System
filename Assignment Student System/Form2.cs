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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment_Student_System
{
    public partial class Form2 : Form
    {
        public string FB;


        public Form2(string FC)
        {
            InitializeComponent();
            FB = FC;
            lblTutor.Text = FB;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(FB);
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FILLDGV();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FILLDGV();
        }
        private void FILLDGV()
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
                con.Open();
                string query = "select * from classes";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                dgvAllData.DataSource = dataTable;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvAllData.SelectedRows.Count == 1)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
                con.Open();
                DataGridViewRow selected = dgvAllData.CurrentRow;
                string TutorName = (string)selected.Cells[1].Value;
                string subjectName = (string)selected.Cells[2].Value;
                SqlCommand sqlCommand = new SqlCommand("delete from classes where Tutor_Name = @A and Subject_Name = @B", con);
                sqlCommand.Parameters.AddWithValue("@A", TutorName);
                sqlCommand.Parameters.AddWithValue("@B", subjectName);
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
        }

        private void lblTutor_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateClass UpdateForm= new UpdateClass(FB);
            _ = UpdateForm.ShowDialog();
        }
    }
}
