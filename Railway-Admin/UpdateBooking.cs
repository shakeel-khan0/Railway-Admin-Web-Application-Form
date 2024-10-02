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
    public partial class UpdateBooking : Form
    {
        public UpdateBooking()
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
        private void getdata()
        {
            SqlConnection con = new SqlConnection("Data Source=SHAKEEL-KHAN\\SQLEXPRESS;Initial Catalog=\"Assinmnt 2 VP\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            string query = "Select * from Bookings";
            SqlDataAdapter bookadt = new SqlDataAdapter(query, con);

            string query1 = "select * from Train";
            SqlDataAdapter trainadt = new SqlDataAdapter(query1, con);

            string query2 = "select AdminID from Admins";
            SqlDataAdapter adminadt = new SqlDataAdapter(query2, con);
            con.Open();

            DataTable dt = new DataTable();
            bookadt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                bookinidcombbo.DataSource = dt;
                bookinidcombbo.DisplayMember = "BookingID";
                admincombo.DataSource = dt;
                admincombo.DisplayMember = "AdminID";
                
            }
            DataTable dt2 = new DataTable();
            trainadt.Fill(dt2);
            if(dt2.Rows.Count>0)
            {
                traincombo.DataSource = dt2;
                traincombo.DisplayMember = "TrainID";
                comboBox1.DataSource = dt2;
                comboBox1.DisplayMember = "Source";
                comboBox2.DataSource = dt2;
                comboBox2.DisplayMember = "Destination";
            }

            
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SHAKEEL-KHAN\\SQLEXPRESS;Initial Catalog=\"Assinmnt 2 VP\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            string query1 = "Update Bookings set TrainID=@TrainID, PassengerName=@PassengerName, SeatNo=@SeatNo," +
                "MobileNo=@MobileNo,Departure=@Departure,Arrival=@Arrival,TravelDate=@TravelDate,SeatsBooked=@SeatsBooked"
                + ",TrainClass=@TrainClass, TicketType=@TicketType, AdminID=@AdminID where BookingID=@BookingID";
            con.Open();
            SqlCommand cmd = new SqlCommand(query1, con);
            cmd.Parameters.AddWithValue("@TrainID", traincombo.Text);
            cmd.Parameters.AddWithValue("@BookingID", bookinidcombbo.Text);
            cmd.Parameters.AddWithValue("@PassengerName", textBox3.Text);
            cmd.Parameters.AddWithValue("@SeatNo", seatnocombo.Text);
            cmd.Parameters.AddWithValue("@MobileNo", textBox5.Text);
            cmd.Parameters.AddWithValue("@Departure", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Arrival", comboBox2.Text);
            cmd.Parameters.AddWithValue("@TravelDate", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@SeatsBooked", numericUpDown2.Value);
            cmd.Parameters.AddWithValue("@TrainClass", classtypcombi.Text);
            cmd.Parameters.AddWithValue("@TicketType", tickttypcombo.Text);
            cmd.Parameters.AddWithValue("@AdminID", admincombo.Text);
            int rowsaffected = cmd.ExecuteNonQuery();
            if (rowsaffected > 0)
            {
                MessageBox.Show("Data Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Manage manage = new Manage();
                manage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No rows updated! Check your input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Manage manage = new Manage();
            manage.Show();
            this.Hide();
        }
    }
}
