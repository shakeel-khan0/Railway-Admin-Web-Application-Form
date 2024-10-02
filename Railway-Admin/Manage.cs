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

namespace Assinmnt
{
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
            getdata();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void mngtrainbtn_Click(object sender, EventArgs e)
        {
            Train train = new Train();
            train.Show();
            this.Hide();
        }

        private void getdata()
        {
            SqlConnection con = new SqlConnection("Data Source=SHAKEEL-KHAN\\SQLEXPRESS;Initial Catalog=\"Assinmnt 2 VP\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            string query = "select * from Bookings";
            con.Open();
            SqlDataAdapter adt = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            bookingdataview.DataSource = dt;
            con.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            UpdateBooking updateBooking = new UpdateBooking();
            updateBooking.Show();
            this.Hide();
        }

        private void cancl_Click(object sender, EventArgs e)
        {
            deletbook deletbook = new deletbook();
            deletbook.Show();
            this.Hide();
        }
    }
}
