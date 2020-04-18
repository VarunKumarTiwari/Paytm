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
    public partial class spalsh : Form
    {
        public spalsh()
        {
            InitializeComponent();
            this.TransparencyKey = (BackColor);
        }

        private void spalsh_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Increment(1);
            if (progressBar1.Value==100)
            {
                timer1.Stop();
                Login frm = new Login();
                frm.Show();
                this.Hide();

            }
        }
    }
}
