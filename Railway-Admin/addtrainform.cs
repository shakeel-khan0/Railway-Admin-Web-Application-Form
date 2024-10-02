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
    public partial class addtrainform : Form
    {
        public addtrainform()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Train train = new Train();
            train.Show();
            this.Hide();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
        }


        private void trainnamecombo_Click(object sender, EventArgs e)
        {
            trainnamecombo.ForeColor = Color.Black;
        }

        private void sourcecombo_Click(object sender, EventArgs e)
        {
            sourcecombo.ForeColor = Color.Black;
        }

        private void destinationcombo_Click(object sender, EventArgs e)
        {
            destinationcombo.ForeColor = Color.Black;
        }

        private void arivtimcombo_Click(object sender, EventArgs e)
        {
            arivtimcombo.ForeColor = Color.Black;
        }

        private void deptimecombo_Click(object sender, EventArgs e)
        {
            deptimecombo.ForeColor = Color.Black;
        }

        private void trainnamecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            label18.Visible = false;
        }

        private void destinationcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            label17.Visible = false;
        }

        private void arivtimcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void deptimecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
        }
        private void addtrain_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(trainnamecombo.Text) || trainnamecombo.Text == "(select name)" ||
                string.IsNullOrWhiteSpace(sourcecombo.Text) || sourcecombo.Text == "(select source)" ||
                string.IsNullOrWhiteSpace(destinationcombo.Text) || destinationcombo.Text == "(select destination)" ||
                string.IsNullOrWhiteSpace(deptimecombo.Text) || deptimecombo.Text == "(select departure time)" ||
                string.IsNullOrWhiteSpace(arivtimcombo.Text) || arivtimcombo.Text == "(select arrival time)")
            {
                label5.Visible = true;
                label18.Visible = true;
                label7.Visible = true;
                label17.Visible = true;
                label12.Visible = true;
                MessageBox.Show("Please! fill all the fields. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=SHAKEEL-KHAN\\SQLEXPRESS;Initial Catalog=\"Assinmnt 2 VP\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                string query = "insert into Train values(@TrainName,@Source,@Destination,@DepartureTime,@ArrivalTime)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TrainName", trainnamecombo.Text);
                cmd.Parameters.AddWithValue("@Source", sourcecombo.Text);
                cmd.Parameters.AddWithValue("@Destination", destinationcombo.Text);
                cmd.Parameters.AddWithValue("@DepartureTime", deptimecombo.Text);
                cmd.Parameters.AddWithValue("@ArrivalTime", arivtimcombo.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("SuccessFully added data to database!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Train train = new Train();
            train.Show();
            this.Hide();
        }
    }
}
