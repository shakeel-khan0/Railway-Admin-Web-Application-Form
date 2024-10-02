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
    public partial class Signup2 : Form
    {
        public Signup2()
        {
            InitializeComponent();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.White;
        }

        private void sbmtbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "+92-3××-×××××××")
            {
                textBox1.Text = "Invalid Caridentials";
                textBox1.ForeColor = Color.Red;
                textBox1.Visible = true;
                MessageBox.Show("Fill the requirments", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Registration Successfull.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Signup sign = new Signup();
            sign.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
