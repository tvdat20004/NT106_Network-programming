using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class bai5 : Form
    {
        public bai5()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = input.Text;
            string[] mark_str = userInput.Split(' ');
            List <double> mark = new List<double>();
            double sum = 0;
            try
            {
                for (int i = 0; i < mark_str.Length; i++)
                {
                    if (mark_str[i] == "")
                    {
                        continue;
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("Nhập điểm sai định dạng!!!");
                return;
            }
            string output = "";
            for (int i = 0; i < mark_str.Length; i++)
            {
                Double pt;
                if (mark_str[i] == "")
                {
                    continue;
                }
                try
                {
                    pt = Double.Parse(mark_str[i]);
                }
                catch
                {
                    MessageBox.Show("Nhập sai định dạng!!!");
                    return;
                }
                if (pt < 0 || pt > 10)
                {
                    MessageBox.Show("Điểm không hợp lệ!!!");
                    return;
                }
                mark.Add(pt);
            }   
            for (int i = 0; i < mark.Count; i++)
            {
                output += "Môn " + (i + 1).ToString() + ": " + mark[i] + "đ\t";
                sum += mark[i];
                if ((i + 1) % 6 == 0)
                {
                    output += "\n";
                }
            }
            richTextBox1.Text = output;
            double ava = sum / mark.Count;
            double minMark = mark.Min();
            double maxMark = mark.Max();
            avarage.Text = (ava).ToString();
            max.Text = maxMark.ToString() + "đ";
            min.Text = minMark.ToString() + "đ";
            pass.Text = mark.Where(x => x >= 5).Count().ToString();
            fail.Text = mark.Where(x => x < 5).Count().ToString();
            if (ava >= 8 && minMark >= 6.5)
            {
                rank.Text = "Giỏi";
            }
            else if (ava >= 6.5 && minMark >= 5)
            {
                rank.Text = "Khá";
            }
            else if (ava >= 5 && minMark >= 3.5)
            {
                rank.Text = "Trung bình";
            }
            else if (ava >= 3.5 && minMark >= 2)
            {
                rank.Text = "Yếu";
            }
            else if (ava < 3.5 || minMark < 2)
            {
                rank.Text = "Kém";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input.Clear();
            richTextBox1.Clear();
            min.Clear();
            max.Clear();
            rank.Clear();
            avarage.Clear();
            pass.Clear();
            fail.Clear();
        }

        private void avarage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
