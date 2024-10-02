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
    public partial class deletbook : Form
    {
        public deletbook()
        {
            InitializeComponent();
            getdata();
        }

        private void getdata()
        {
            SqlConnection con = new SqlConnection("Data Source=SHAKEEL-KHAN\\SQLEXPRESS;Initial Catalog=\"Assinmnt 2 VP\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            string q = "select * from Bookings";
            SqlDataAdapter adt = new SqlDataAdapter(q, con);
            con.Open();
            DataTable dt = new DataTable();
            adt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                trainid.DataSource = dt;
                trainid.DisplayMember = "BookingID";

            }
        }
        private void delettrainbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel booking?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=SHAKEEL-KHAN\\SQLEXPRESS;Initial Catalog=\"Assinmnt 2 VP\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                string q = "delete from Bookings where BookingID =@BookingID ";
                con.Open();
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@BookingID", trainid.Text);
                int rowsaffected = cmd.ExecuteNonQuery();
                if (rowsaffected > 0)
                {
                    MessageBox.Show("Booking Cancelation Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Manage train = new Manage();
                    train.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Cancelation error! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Manage manage = new Manage();
            manage.Show();
            this.Hide();
        }
    }
}
