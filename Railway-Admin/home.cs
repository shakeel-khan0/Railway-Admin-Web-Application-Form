using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assinmnt
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            getdata();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bookbtn_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.ForeColor = Color.Black;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.ForeColor = Color.Black;
        }

        private void mngbookbtn_Click(object sender, EventArgs e)
        {
            Manage manage = new Manage();
            manage.Show();
            this.Hide();
        }

        private void getdata()
        {
            SqlConnection con = new SqlConnection("Data Source=SHAKEEL-KHAN\\SQLEXPRESS;Initial Catalog=\"Assinmnt 2 VP\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            string q = "select * from Train";
            SqlDataAdapter trainadt = new SqlDataAdapter(q, con);
            con.Open();
            DataTable traintab = new DataTable();
            trainadt.Fill(traintab);
            if (traintab.Rows.Count > 0)
            {
                comboBox1.DataSource = traintab;
                comboBox1.DisplayMember = "Source";
                comboBox2.DataSource = traintab;
                comboBox2.DisplayMember = "Destination";
                
            }
        }
        private void srchtranbtn_Click(object sender, EventArgs e)
        {            
            SqlConnection con = new SqlConnection("Data Source=SHAKEEL-KHAN\\SQLEXPRESS;Initial Catalog=\"Assinmnt 2 VP\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            string query = "select * from Train where Source=@Source and Destination=@Destination";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Source",comboBox1.Text);
            cmd.Parameters.AddWithValue("Destination",comboBox2.Text);
            try
            {
                con.Open();
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                if (dt.Rows.Count > 0) 
                {
                    Search search = new Search(dt);
                    search.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching for trains: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void mngtrainbtn_Click(object sender, EventArgs e)
        {
            Train train = new Train();
            train.Show();
            this.Hide();
        }
    }
}
