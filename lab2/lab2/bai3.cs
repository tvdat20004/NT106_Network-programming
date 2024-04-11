using System;
using System.IO;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace lab2
{
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }
        string URL = "";
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                string url = file.FileName;
                URL = url;
                FileStream fs = new FileStream(url, FileMode.Open, FileAccess.Read, FileShare.Read);
                Byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, (int)fs.Length);
                string content = Encoding.UTF8.GetString(bytes);
                richTextBox1.Text = content;
                fs.Close();
            }
        }
        /* Write a function that can evaluate an expression and caculate the result*/

        private double evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Please open a file first!");
                return;
            }
            string[] lines = richTextBox1.Text.Split('\n');
            string result = "";
            foreach (string line in lines)
            {
                try
                {
                    result += line + " = " + evaluate(line).ToString() + "\n";
                }
                catch
                {
                    MessageBox.Show("Invalid expression: " + line + "\n");
                    return;
                }
            }
            richTextBox2.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (URL == "")
            {
                MessageBox.Show("Please open a file first!");
                return;
            }
            if (richTextBox2.Text == "")
            {
                MessageBox.Show("Please evaluate the expressions first!");
                return;
            }
            string newUrl = URL.Split('.')[0] + "_output.txt";
            FileStream fs = new FileStream(newUrl, FileMode.Create, FileAccess.Write, FileShare.None);
            Byte[] bytes = Encoding.UTF8.GetBytes(richTextBox2.Text);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();
            MessageBox.Show("File created successfully!");
        }
    }
}
