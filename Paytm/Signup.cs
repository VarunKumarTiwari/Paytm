using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Paytm
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

           // textBox3.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your are not login yet");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your are not login yet");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your are not login yet");
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Paytm;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("insert into signup(mobile,name,mail) values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "')", con);
            //SqlDataAdapter ad = new SqlDataAdapter(cmd);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Created your id");
            con.Close();
        }
    }
}
