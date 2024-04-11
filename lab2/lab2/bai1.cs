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
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                string url = file.FileName;
                textBox1.Text = url;
                FileStream fs = new FileStream(url, FileMode.Open, FileAccess.Read, FileShare.Read);
                Byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, (int)fs.Length);
                string content = Encoding.UTF8.GetString(bytes);
                richTextBox1.Text = content;
                fs.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string content = richTextBox1.Text;
            content = content.ToUpper();

            CreateOrOverwrite choose = new CreateOrOverwrite();
            choose.ShowDialog();
            string result = choose.getResult();
            if (result == "create")
            {
                FolderBrowserDialog path = new FolderBrowserDialog();
                if (path.ShowDialog() == DialogResult.OK)
                {
                    string filename = Path.GetFileName(textBox1.Text);
                    string url = path.SelectedPath + "\\" + filename.Split('.')[0] + "_new.txt";
                    FileStream fs = new FileStream(url, FileMode.Create, FileAccess.Write, FileShare.None);
                    Byte[] bytes = Encoding.UTF8.GetBytes(content);
                    fs.Write(bytes, 0, bytes.Length);
                    fs.Close();
                    MessageBox.Show("File created successfully!");
                }
            }
            else if (result == "overwrite")
            {
                FileStream fs = new FileStream(textBox1.Text, FileMode.Create, FileAccess.Write, FileShare.None);
                Byte[] bytes = Encoding.UTF8.GetBytes(content);
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
                MessageBox.Show("File overwritten successfully!");
            }
            else{
                MessageBox.Show("Please choose an option!");
            }
        }
    }
}
