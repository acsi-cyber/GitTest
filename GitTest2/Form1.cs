﻿using form3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTest2
{
    public partial class Form1 : Form
    {
        public static string text1;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.label1.Text = this.textBox1.Text;
            frm2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox2.Text);
            int num2 = Convert.ToInt32(textBox3.Text);
            num1 += num2;

            Form2 frm2 = new Form2();
            frm2.label1.Text = num1.ToString();
            frm2.Show();
        }
    }
}
