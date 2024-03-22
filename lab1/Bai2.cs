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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double n1=0, n2=0, n3=0;
            try
            {
                n1 = Double.Parse(num1.Text.Trim());
                n2 = Double.Parse(num2.Text.Trim());
                n3 = Double.Parse(num3.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Hãy nhập số hợp lệ!!!");
                return;
            }
            Double minn = Math.Min(Math.Min(n1, n2),n3);
            Double maxx = Math.Max(Math.Max(n1, n2), n3);
            min.Text = minn.ToString();
            max.Text = maxx.ToString();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            min.Text = "";
            max.Text = "";
            num1.Text = "";
            num2.Text = "";
            num3.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
