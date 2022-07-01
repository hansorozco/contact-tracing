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
using Excel = Microsoft.Office.Interop.Access;
using MessageBox = System.Windows.Forms.MessageBox;
using ZXing;
using ZXing.QrCode;

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

               private void exitbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using this program." +
                " Have a nice day!");
            System.Windows.Forms.Application.Exit();
        }

             void ConvertToaccdb(string sourcefile, string destfile)
        {
            int i, j;
            StreamWriter accdbfile;
            string[] lines, cells;
            lines = File.ReadAllLines(sourcefile);
            accdbfile = new StreamWriter(destfile);
            for (i = 0; i < lines.Length; i++)
            {
                cells = lines[i].Split(new Char[] { '\t', ';' });
                for (j = 0; j < cells.Length; j++)
                    accdbfile.Write(cells[j] + ",");
                accdbfile.WriteLine();
            }
            accdbfile.Close();
        }

        private void savebutton_clicked(object sender, EventArgs e)
        {
            //stream writer file = file.appendtext("@Downloads\test.txt")

            string[] data = new string[4];
            data[0] = namebox.Text;
            data[1] = datebox.Text;
            data[2] = addressbox.Text;
            data[3] = numberbox.Text;
            StreamReader sr = new StreamReader(@"savedinfounit1.txt");
            string oldatat = sr.ReadLine();
            sr.Close();// important
            StreamWriter sw = new StreamWriter(@"savedinfounit1.txt");
            sw.WriteLine("Name: " + data[0]
                + " Date: " + data[1]

                + " Address: " + data[2]

                + " Contact Number:" + data[3]

                + Environment.NewLine + oldatat);
            MessageBox.Show("Information Saved. Thank you very much!");
            sw.Close();// important to close
        }

         private void clearbutton_cliked(object sender, EventArgs e)
        {
            namebox.Clear();
            datebox.Clear();
            addressbox.Clear();
            numberbox.Clear();
            MessageBox.Show("TEXT BOXES CLEARED");
        }

        private void checkinfobutton_clicked(object sender, EventArgs e)
        {
            StreamReader inputFile = new StreamReader(@"savedinfounit1.txt");
            infotextbox_a.Text = inputFile.ReadToEnd();
            inputFile.Close();
        }


        private void savebutton2_clicked(object sender, EventArgs e)
        {
            //stream writer file = file.appendtext("@Downloads\test.txt")

            string[] data = new string[4];
            data[0] = namebox2.Text;
            data[1] = datebox2.Text;
            data[2] = addressbox2.Text;
            data[3] = numberbox2.Text;
            StreamReader sr = new StreamReader(@"savedinfounit2.txt");
            string oldatat = sr.ReadLine();
            sr.Close();// important
            StreamWriter sw = new StreamWriter(@"savedinfounit2.txt");
            sw.WriteLine("Name: " + data[0]
                + " Date: " + data[1]

                + " Address: " + data[2]

                + " Contact Number:" + data[3]

                + Environment.NewLine + oldatat);
            MessageBox.Show("Information Saved. Thank you very much!");
            sw.Close();// important to close
        }

        private void clearbutton2_click(object sender, EventArgs e)
        {
            namebox2.Clear();
            datebox2.Clear();
            addressbox2.Clear();
            numberbox2.Clear();
            MessageBox.Show("TEXT BOXES CLEARED");
        }

        private void checkinfobutton2_clicked(object sender, EventArgs e)
        {
            StreamReader inputFile = new StreamReader(@"savedinfounit2.txt");
            infotextbox_b.Text = inputFile.ReadToEnd();
            inputFile.Close();
        }

        private void generatebutton1_Click(object sender, EventArgs e)
        {
            var options = new QrCodeEncodingOptions
            {
                Height = qrcodebox1.Height,
                Width = qrcodebox1.Width
            };
            // create instance of barcodewriter
            var writer = new BarcodeWriter();
            // set format
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options= options;
            var Text =  namebox.Text + datebox.Text  + addressbox.Text + numberbox.Text ;
            var result = writer.Write(Text);
            qrcodebox1.Image = result;
        }

        
    }
}

