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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
            Booking_Load();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.ForeColor = Color.Black;
           // label19.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.ForeColor = Color.Black;
           // label18.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Black;
           // label12.Visible = false;
        }
        private void traincombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            traincombo.ForeColor = Color.Black;
            //label16.Visible = false;
        }
        private void admincombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            admincombo.ForeColor = Color.Black;
            //label8.Visible = false;
        }

        private void classtypcombi_SelectedIndexChanged(object sender, EventArgs e)
        {
            classtypcombi.ForeColor = Color.Black;
           // label22.Visible = false;
        }
        private void tickttypcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tickttypcombo.ForeColor = Color.Black;
            //label21.Visible = false;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.ForeColor = Color.Black;
            //label17.Visible = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }

        private void Booking_Load()
        {
            SqlConnection con = new SqlConnection("Data Source=SHAKEEL-KHAN\\SQLEXPRESS;Initial Catalog=\"Assinmnt 2 VP\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            string query = "select * from Train";
            SqlDataAdapter trainad = new SqlDataAdapter(query, con);
            string query1 = "select AdminID from Admins";
            SqlDataAdapter adminad = new SqlDataAdapter(query1, con);
            con.Open();
            DataTable traintab = new DataTable();
            trainad.Fill(traintab);
            if(traintab.Rows.Count > 0)
            {
                traincombo.DataSource = traintab;
                traincombo.DisplayMember = "TrainID";
                comboBox1.DataSource = traintab;
                comboBox1.DisplayMember = "Source";
                comboBox2.DataSource = traintab;
                comboBox2.DisplayMember = "Destination";
            }

            DataTable admintab = new DataTable();
            adminad.Fill(admintab);
            if(admintab.Rows.Count>0)
            {
                admincombo.DataSource = admintab;
                admincombo.DisplayMember = "AdminId";
            }
            con.Close();

        }
        private void crdbtn_Click(object sender, EventArgs e)
        {
            label12.Visible = false;
            label17.Visible = false;
            label21.Visible = false;
            label22.Visible = false;

            if (
                string.IsNullOrWhiteSpace(classtypcombi.Text) || classtypcombi.Text == "(select arrival city)" ||
                string.IsNullOrWhiteSpace(tickttypcombo.Text) || tickttypcombo.Text == "(select departure city)" ||
                string.IsNullOrWhiteSpace(seatnocombo.Text) || seatnocombo.Text == "(select seat number)" ||
                string.IsNullOrEmpty(textBox3.Text) || textBox3.Text == "(enter name)" ||
                string.IsNullOrEmpty(textBox5.Text) || textBox5.Text == "03×××××××××")
            {
                label12.Visible = true;
                label17.Visible = true;
                label21.Visible = true;
                label22.Visible = true;

                MessageBox.Show("Please fill in all required information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to book the ticket?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection("Data Source=SHAKEEL-KHAN\\SQLEXPRESS;Initial Catalog=\"Assinmnt 2 VP\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                string query = "insert into Bookings values (@TrainID,@PassengerName,@SeatNo,@MobileNo,@Departure,@Arrival" +
                               ",@TravelDate,@SeatsBooked,@TrainClass,@TicketType,@AdminID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TrainID", traincombo.Text);
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

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thank you for booking with us!\nBooking successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Manage homeForm = new Manage();
                    homeForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while adding data to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    conn.Close();
                }

            }
            else
            {
                MessageBox.Show("Booking cancelled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                home homeForm = new home();
                homeForm.Show();
                this.Hide();
            }
        }

        private void mngbookbtn_Click(object sender, EventArgs e)
        {
            Manage manage = new Manage();
            manage.Show();
            this.Hide();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mngtrainbtn_Click(object sender, EventArgs e)
        {
            Train train = new Train();
            train.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
