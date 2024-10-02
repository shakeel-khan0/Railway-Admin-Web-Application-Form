namespace Assinmnt
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void loginwel_Click(object sender, EventArgs e)
        {
            Login login = new();
            login.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginwel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginwel.PerformClick();
            }
        }
    }
}
