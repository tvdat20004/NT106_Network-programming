using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Multiselect = true
            };
            ofd.ShowDialog();
            string output = "";

            foreach(string filename in ofd.FileNames)
            {
                StreamReader str = new StreamReader(filename);
                int count = 0;
                while (str.ReadLine() != null)
                {
                    count++;
                }
                output += filename + ':' + count.ToString() + " lines. \n";
                str.Close();
            }
            richTextBox1.Text = output;   
        }
    }
}
