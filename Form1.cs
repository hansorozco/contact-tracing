﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ContacTracibng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1click(object sender, EventArgs e)
        {
            //stream writer file =file.append("C:\\Users\\hans\\source\\test.txt"),true;

            StreamWriter file = new StreamWriter("C:\\Users\\hans\\source\\test.txt");
            file.WriteLine("Complete Name :" + textBox1.Text);
            file.WriteLine("Complete Date :" +textBox2.Text);
            file.WriteLine("Address :"+textBox1.Text);
            file.WriteLine("Contact Number :" + textBox1.Text);
            MessageBox.Show("Thank you very much");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
