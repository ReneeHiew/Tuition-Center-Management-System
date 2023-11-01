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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment_Student_System
{
    public partial class Form3 : Form
    {
        public string FB;
        public Form3(string FB)
        {
            InitializeComponent();
            this.FB = FB;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCharges_Click(object sender, EventArgs e)
        {

        }

        public void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lbl50.Text) && !String.IsNullOrEmpty(cmbClass.Text) && !String.IsNullOrEmpty(txtDate.Text) && !String.IsNullOrEmpty(txtTime.Text))
            {
                try
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into[dbo].[classes] ([Tutor_Name],[Subject_Name],[Date],[Time],[Class_Charges])  Values('" + FB + "','" + cmbClass.Text + "', '" + txtDate.Text + "', '" + txtTime.Text + "', '" + lbl50.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    ListViewItem newitem = new ListViewItem(FB);
                    newitem.SubItems.Add(cmbClass.Text);
                    newitem.SubItems.Add(txtDate.Text);
                    newitem.SubItems.Add(txtTime.Text);
                    newitem.SubItems.Add(lbl50.Text);
                    listView1.Items.Add(newitem);
                    lblTutor.Text = "";
                    cmbClass.Text = "";
                    txtDate.Text = "";
                    txtTime.Text = "";
                    lbl50.Text = "";

                    MessageBox.Show("You is Successfully added in the system");

                    Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Fill In the Empty Field");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl50_Click(object sender, EventArgs e)
        {

        }
    }
}
