using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text files (*.txt)|*.txt";
            if (file.ShowDialog() == DialogResult.OK)
            {
                string url = file.FileName;
                path.Text = url;
                filename.Text = file.SafeFileName;
                StreamReader sr = new StreamReader(url);
                string content = sr.ReadToEnd();
                sr.Close();
                char[] delimiterChars = {' ', ',', '.', ':', '\t', '\n'};

                var words = content.Split(delimiterChars);
                int wordcount = 0;
                foreach (var word in words)
                {
                    if (word != "")
                    {
                        wordcount++;
                    }
                }
                richTextBox1.Text = content;
                numWord.Text = wordcount.ToString();
                int linecount = 0, charcount = 0;
                foreach (char c in content)
                {
                    charcount++;
                    if (c == '\n')
                    {
                        linecount++;
                    }
                }
                numLine.Text = (linecount+1).ToString();
                numChar.Text = charcount.ToString();
            }
        }

        private void bai2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
