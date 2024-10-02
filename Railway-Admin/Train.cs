using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assinmnt
{
    public partial class Train : Form
    {
        public Train()
        {
            InitializeComponent();
            retrievedata();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void mngbookbtn_Click(object sender, EventArgs e)
        {
            Manage manage = new Manage();
            manage.Show();
            this.Hide();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void bookbtn_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addtrain_Click(object sender, EventArgs e)
        {
            addtrainform addtrainform = new addtrainform();
            addtrainform.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void retrievedata()
        {
            SqlConnection con = new SqlConnection("Data Source=SHAKEEL-KHAN\\SQLEXPRESS;Initial Catalog=\"Assinmnt 2 VP\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            string query = "select * from Train";
            con.Open();
            SqlDataAdapter adt = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void deletetrain_Click(object sender, EventArgs e)
        {
            deletetrain deletetrain  = new deletetrain();
            deletetrain.Show();
            this.Hide();
        }

        private void updatetrain_Click(object sender, EventArgs e)
        {
            Updatetrain updatetrain = new Updatetrain();
            updatetrain.Show();
            this.Hide();
        }
    }
}

