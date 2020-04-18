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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void payment_Load(object sender, EventArgs e)
        {
            label4.Text = addmoneynext.amt;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
           
        }

        private void label12_Click(object sender, EventArgs e)
        {

            
        }

        private void label11_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            debit d = new debit();
            d.Show();
            this.Hide();
        }

        private void label12_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            credit d = new credit();
            d.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "707")
            {
                SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Paytm;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmdd = new SqlCommand("insert into adda(CardNo,amt) values( @number,@amount)", conn);
                cmdd.Parameters.AddWithValue("@number",radioButton1.Text);
                cmdd.Parameters.AddWithValue("@amount", label4.Text);
                //SqlDataAdapter ad = new SqlDataAdapter(cmd);
                conn.Open();
                cmdd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("add successfully");
                MessageBox.Show("Payment Successfull");
               
            }
            else
            {
                MessageBox.Show("Wrong CVV");
            }
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
    }
}
