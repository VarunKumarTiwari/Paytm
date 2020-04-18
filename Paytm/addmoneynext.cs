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
    public partial class addmoneynext : Form
    {
        public static string amt;
        public addmoneynext()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s=50;
            richTextBox1.Text =s.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int s = 100;
            richTextBox1.Text = s.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int s = 200;
            richTextBox1.Text = s.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            amt = richTextBox1.Text;
            payment p = new payment();
            p.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pay p = new pay();
            p.Show();
            this.Hide();
        }

        private void addmoneynext_Load(object sender, EventArgs e)
        {
            


            label4.Text = addmoneynext.amt;
        }
    }
}
