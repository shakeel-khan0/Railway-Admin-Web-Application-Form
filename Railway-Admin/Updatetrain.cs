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
    public partial class Updatetrain : Form
    {
        public Updatetrain()
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
            string q = "select * from Train";
            SqlDataAdapter adt = new SqlDataAdapter(q, con);
            con.Open();
            DataTable dt = new DataTable();
            adt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                trainid.DataSource = dt;
                trainid.DisplayMember = "TrainID";

            }
        }


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updttrain_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SHAKEEL-KHAN\\SQLEXPRESS;Initial Catalog=\"Assinmnt 2 VP\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            string query = "Update Train set TrainName=@TrainName,Source=@Source,Destination=@Destination,DepartureTime=@DepartureTime,ArrivalTime=@ArrivalTime where TrainID=@TrainID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@TrainID", trainid.Text);
            cmd.Parameters.AddWithValue("@TrainName", trainnamecombo.Text);
            cmd.Parameters.AddWithValue("@Source", sourcecombo.Text);
            cmd.Parameters.AddWithValue("@Destination", destinationcombo.Text);
            cmd.Parameters.AddWithValue("@DepartureTime", deptimecombo.Text);
            cmd.Parameters.AddWithValue("@ArrivalTime", arivtimcombo.Text);
            con.Open();

            int rowsaffected = cmd.ExecuteNonQuery();
            if (rowsaffected > 0)
            {
                MessageBox.Show("Train Data Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Train manage = new Train();
                manage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No rows updated! Check your input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Train train = new Train();
            train.Show();
            this.Hide();
        }
    }
}
