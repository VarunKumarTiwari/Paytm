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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

         }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill all details");
            }
            else {
                if (textBox1.Text == "varun" || textBox2.Text == "12345")
                {
                    main m = new main();
                    m.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Please check USER NAME or PASSWORD");
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.UseSystemPasswordChar = true;
            textBox2.PasswordChar = '*';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Signup f = new Signup();
            f.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please login first");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please login first");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please login first");
        }
    }
}
