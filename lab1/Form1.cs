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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1=0, n2=0;
            long result = 0;
            double result_div = 0;
            try
            {
                n1 = Int32.Parse(num1.Text.Trim());
                n2 = Int32.Parse(num2.Text.Trim());
            }
            catch 
            {
                MessageBox.Show("Hãy nhập số nguyên!!!");
                return;
            }
            if (!(plus.Checked || minus.Checked || mul.Checked|| div.Checked))
            {
                MessageBox.Show("Hãy chọn 1 phép tính");
                return;
            }
            if (plus.Checked)
            {
                result = (long)n1 + n2;
            }    
            else if (minus.Checked)
            {
                result = (long)n1 - n2;
            }
            else if (mul.Checked)
            {
                result = (long)n1 * n2;
            }
            else if (div.Checked)
            {
                result_div = (n1*1.0) / (n2*1.0);
                textBox3.Text = result_div.ToString();
                return;
            }
            textBox3.Text = result.ToString();
            return;
            
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
            textBox3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
