﻿using System;
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
    public partial class Success : Form
    {
        public static string ss;
        public Success()
        {

            InitializeComponent();
        }

        private void Success_Load(object sender, EventArgs e)
        {
            label2.Text = pay.args;
            label3.Text = pay.args1;
            label4.Text = pay.args2;
            ss = label4.Text;
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
