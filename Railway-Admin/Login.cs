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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                textBox1.ForeColor = Color.White;

                label7.Visible = false;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
                textBox2.ForeColor = Color.White;
                label8.Visible = false;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                label7.Text = "please enter username";
                label8.Text = "please enter password";
                label7.Visible = true;
                label8.Visible = true;
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=SHAKEEL-KHAN\\SQLEXPRESS;Initial Catalog=\"Assinmnt 2 VP\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            string query = "select count (*) from Admins where UserName=@UserName and Password=@Password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@Password", password);
            try
            {
                con.Open();
                int result = (int)cmd.ExecuteScalar();
                con.Close();

                if (result > 0)
                {
                    home home = new home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    label7.Text = "invalid username";
                    label8.Text = "invalid password";
                    label7.Visible = true;
                    label8.Visible = true;
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show("An error occured!" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minbtn_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginbtn.PerformClick();
            }
        }
    }
}
