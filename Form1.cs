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
            //stream writer file = file.appendtext("@Downloads\test.txt")

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
            MessageBox.Show("Thank you for using this program." +
                " Have a nice day!");
            Application.Exit();
        }

        private void savebutton2_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\hans\source\testing2.txt");
            file.WriteLine("Complete Name :" + namebox2.Text);
            file.WriteLine("Complete Date :" + datebox2.Text);
            file.WriteLine("Address :" + addressbox2.Text);
            file.WriteLine("Contact Number :" + numberbox2.Text);
            file.Close();
            MessageBox.Show("Thank you very much!");
        }

        private void savaebutton3_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\hans\source\testing3.txt");
            file.WriteLine("Complete Name :" + namebox3.Text);
            file.WriteLine("Complete Date :" + datebox3.Text);
            file.WriteLine("Address :" + addressbox3.Text);
            file.WriteLine("Contact Number :" + numberbox3.Text);
            file.Close();
            MessageBox.Show("Thank you very much!");
        }

        private void savebutton4_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\hans\source\testing4.txt");
            file.WriteLine("Complete Name :" + namebox4.Text);
            file.WriteLine("Complete Date :" + datebox4.Text);
            file.WriteLine("Address :" + addressbox4.Text);
            file.WriteLine("Contact Number :" + numberbox4.Text);
            file.Close();
            MessageBox.Show("Thank you very much!");
        }

        private void checkinfobutton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile = new StreamReader(@"C:\Users\hans\source\testing.txt");
            infoTextBox.Text = inputFile.ReadToEnd();
            inputFile.Close();
        }

        private void checkinfobutton2_Click(object sender, EventArgs e)
        {
            StreamReader inputFile = new StreamReader(@"C:\Users\hans\source\testing2.txt");
            infoTextBox2.Text = inputFile.ReadToEnd();
            inputFile.Close();
        }

        private void checkinfobutton3_Click(object sender, EventArgs e)
        {
            StreamReader inputFile = new StreamReader(@"C:\Users\hans\source\testing3.txt");
            infoTextBox3.Text = inputFile.ReadToEnd();
            inputFile.Close();
        }

        private void checkinfobutton4_Click(object sender, EventArgs e)
        {
            StreamReader inputFile = new StreamReader(@"C:\Users\hans\source\testing4.txt");
            infoTextBox4.Text = inputFile.ReadToEnd();
            inputFile.Close();
        }

        private void infoTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

