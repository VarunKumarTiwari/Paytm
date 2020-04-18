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
    public partial class credit : Form
    {
        public credit()
        {
            InitializeComponent();
        }

        private void credit_Load(object sender, EventArgs e)
        {
            label4.Text = addmoneynext.amt;
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {

           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            payment pay = new payment();
            pay.Show();
            this.Hide();
        }

        private void label11_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            debit pay = new debit();
            pay.Show();
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Paytm;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand("insert into cardd(CardNo,month,year,cvv) values(" + textBox2.Text + ",'" + comboBox1.SelectedItem.ToString() + "'," + comboBox2.SelectedItem.ToString() + "," + textBox1.Text + ")", con);
                //SqlDataAdapter ad = new SqlDataAdapter(cmd);
                con.Open();
                cmd.ExecuteNonQuery();

                con.Close();

                SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Paytm;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmdd = new SqlCommand("insert into adda(CardNo,amt) values(" + textBox2.Text + ",'" + label4.Text + "')", conn);
                //SqlDataAdapter ad = new SqlDataAdapter(cmd);
                conn.Open();
                cmdd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("add successfully");
                MessageBox.Show("Payment Successfull");
            }
            else
            {
                MessageBox.Show("Payment Successfull");

            }
        }
    }
    
}
