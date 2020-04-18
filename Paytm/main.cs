using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paytm
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pay p = new pay();
            p.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pay p = new pay();
            p.Show();
            this.Hide();
        }

        private void main_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            addmoneynext addm = new addmoneynext();
            addm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            passbooknext pass = new passbooknext();
            pass.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming Soon....");
        }
    }
}
