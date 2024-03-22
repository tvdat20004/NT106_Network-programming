using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        /*private bool check(string s, int b)
        {
            if (b==2)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != '0' && s[i] != '1')
                        return false;
                }
                return true;
            }
            else if (b==10)
            {
                int n;
                return Int32.TryParse(s, out n);
            }
            else if (b==16)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] )
                }
            }
            }
        }
        */
        
        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            bool check_src = comboBox1.Items.Contains(comboBox1.Text);
            bool check_des = comboBox2.Items.Contains(comboBox2.Text);
            if (!check_src || ! check_des)
            {
                MessageBox.Show("Hãy chọn hệ số hợp lệ !!!");
            }
            try
            {
                string src = comboBox1.Text;
                string des = comboBox2.Text;
                if (src == "Decimal")
                {
                    num = Int32.Parse(num1.Text);
                }
                else if (src =="Binary")
                {
                    num = Convert.ToInt32(num1.Text,2);
                }
                else
                {
                    num = Convert.ToInt32(num1.Text, 16);
                }
                if (des == "Decimal")
                {
                    result.Text = num.ToString();
                }
                else if (des == "Binary")
                {
                    result.Text = Convert.ToString(num, 2);
                }
                else
                {
                    result.Text = Convert.ToString(num, 16);
                }
            }
            catch
            {
                MessageBox.Show("Số không hợp lệ so với hệ cơ số!!!");
                return;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            result.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
