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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public Search(DataTable dt) : this()
        {
            dataGridView1.DataSource = dt;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
