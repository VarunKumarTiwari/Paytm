using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;
using System.Data.SqlClient;
namespace Paytm
{
    public partial class pay : Form
    {
        public static string args;
        public static string args1;
        public static string args2;

        public pay()
        {
            InitializeComponent();
        }
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
           pictureBox4.Image = (Image)eventArgs.Frame.Clone();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pay_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);
        }
            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            button5.Enabled = false;
            button4.Enabled = true;
            button2.Enabled = false;
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            timer1.Start();
            button4.Enabled = false;
            textBox1.Text = "";
           

            MessageBox.Show("done");

        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            string v = "varun",a="ayushi",s="shubhum",ak="akshat";
            int t = 12345,i=123456,b=1111,so=8888;
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pictureBox4.Image);
            try
            {
                string decoded = result.ToString().Trim();
                textBox1.Text = decoded;
                /* SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
                 connectionStringBuilder.DataSource = ".";
                 connectionStringBuilder.InitialCatalog = "TEMP";
                 connectionStringBuilder.IntegratedSecurity = true;
                 SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Paytm;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                 SqlCommand cmd = new SqlCommand("select name,qrcode form payqr where qrcode= @qrc",con);
                 cmd.Parameters.AddWithValue("@qrc",textBox1.Text);
                 con.Open();
                 string value =cmd.ExecuteScalar()as string;
                 con.Close();
                 if (textBox1.Text.Equals(value))*/
               

                    if (textBox1.Text == Convert.ToString(t))
                    {
                        timer1.Stop();
                        button4.Enabled = true;
                      
                        textBox1.Text = decoded;
                    textBox3.Text = v;
                        args = v;
                    args1 = textBox2.Text;
                    args2 = textBox1.Text;
                    Success pyn = new Success();
                        pyn.Show();
                        this.Hide();
                    }
                    if (textBox1.Text == Convert.ToString(i))
                    {
                        timer1.Stop();
                        button4.Enabled = true;
                       
                        textBox1.Text = decoded;
                    textBox3.Text = a;
                    args = a;
                  
                    args1 = textBox2.Text;
                    args2 = textBox1.Text;
                    Success pyn = new Success();
                        pyn.Show();
                        this.Hide();
                    }
                    if (textBox1.Text == Convert.ToString(b))
                    {
                        timer1.Stop();
                        button4.Enabled = true;
                       
                        textBox1.Text = decoded;
                    textBox3.Text = s;
                    args = s;
                   
                    args1 = textBox2.Text;
                    args2 = textBox1.Text;
                    Success pyn = new Success();
                        pyn.Show();
                        this.Hide();
                    }
                    if (textBox1.Text == Convert.ToString(so))
                    {
                        timer1.Stop();
                        button4.Enabled = true;
                        
                        textBox1.Text = decoded;
                    textBox3.Text = ak;
                    args = ak;
                    
                    args1 = textBox2.Text;
                    args2 = textBox1.Text;
                    Success pyn = new Success();
                        pyn.Show();
                        this.Hide();
                    }
                   
                   
          
                
                

            }
            catch(Exception ex)
            {
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
           // timer1.Enabled = true;
        }

        private void pay_FontChanged(object sender, EventArgs e)
        {

        }

        private void pay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
       
            button4.Enabled = true;

            args = textBox1.Text;
            args1 = textBox2.Text;
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Paytm;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("insert into pay(rupee,name,phone) values(" + textBox2.Text + ",'"+textBox3.Text+"'," + textBox1.Text + ")", con);

            con.Open();
            cmd.ExecuteNonQuery();

            con.Close();
          
            MessageBox.Show("done");
            Success pyn = new Success();
            pyn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Hide();
        }
    }
}
