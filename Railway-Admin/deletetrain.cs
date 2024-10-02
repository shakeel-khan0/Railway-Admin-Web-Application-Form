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
    public partial class deletetrain : Form
    {
        public deletetrain()
        {
            InitializeComponent();
            getdata();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Train train = new Train();
            train.Show();
            this.Hide();
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

        private void delettrainbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete train record?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=SHAKEEL-KHAN\\SQLEXPRESS;Initial Catalog=\"Assinmnt 2 VP\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                string query = "delete from Train where TrainID=@TrainID";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TrainID", trainid.Text);

                int rowsaffected = cmd.ExecuteNonQuery();
                if (rowsaffected > 0)
                {
                    MessageBox.Show("Record Deleted Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Train train = new Train();
                    train.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Deletion error! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
