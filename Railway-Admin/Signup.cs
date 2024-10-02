using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assinmnt
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }
        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }
        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.White;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.White;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ForeColor = Color.White;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.ForeColor = Color.White;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "Enter full name" ||
                string.IsNullOrEmpty(textBox2.Text) || textBox2.Text == "Enter username" ||
                string.IsNullOrEmpty(textBox3.Text) || textBox3.Text == "Enter your mail" ||
                string.IsNullOrEmpty(textBox4.Text) || textBox4.Text == "Enter password" ||
                textBox5.Text != textBox4.Text || textBox5.Text == "Confirm password")
            {
                textBox1.Text = "Invalid Credentials";
                textBox1.ForeColor = Color.Red;
                textBox1.Visible = true;
            
                textBox2.Text = "Invalid Credentials";
                textBox2.ForeColor = Color.Red;
                textBox2.Visible = true;

                textBox3.Text = "Invalid Credentials";
                textBox3.ForeColor = Color.Red;
                textBox3.Visible = true;
            
                textBox4.Text = "Invalid Credentials";
                textBox4.ForeColor = Color.Red;
                textBox4.Visible = true;
            
                textBox5.Text = "Incorrect Password";
                textBox5.ForeColor = Color.Red;
                textBox5.Visible = true;
            }
            else
            {
                textBox5.ForeColor = Color.White;
                textBox5.Visible = true;
            }
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Please, Fill all the fields", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Signup2 signup2 = new Signup2();
                signup2.Show();
                this.Hide();
            }
        }

        private void backbtn_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();

        }
    }
}
