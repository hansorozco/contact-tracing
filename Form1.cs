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
using System.Windows;

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


        private void savebuttoon(object sender, EventArgs e)
        {
            //stream writer file =file.append("@Downloads\test.txt")

            StreamWriter file = new StreamWriter(@"C:\Users\hans\source\testing.txt");
            file.WriteLine("Complete Name :" + namebox.Text);
            file.WriteLine("Complete Date :" + datebox.Text);
            file.WriteLine("Address :" + addressbox.Text);
            file.WriteLine("Contact Number :" + numberbox.Text);
            file.Close();
            MessageBox.Show("Thank you very much!");
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void informationbutton(object sender, EventArgs e)
        {
            StreamReader inputFile = new StreamReader(@"C:\Users\hans\source\testing.txt");

        }

        private void addnewinformation(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\hans\source\testing.txt");
            file.WriteLine("Complete Name :" + namebox.Text);
            file.WriteLine("Complete Date :" + datebox.Text);
            file.WriteLine("Address :" + addressbox.Text);
            file.WriteLine("Contact Number :" + numberbox.Text);
            file.Close();
            MessageBox.Show("Thank you very much!");
        }
    }
}

