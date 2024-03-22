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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            bool check1 = Int32.TryParse(number.Text, out num);
            bool check2 = (0 <= num) && (num <= 9);
            if (!check1)
            {
                MessageBox.Show("Hãy nhập số hợp lệ");
                return;
            }
            if (!check2)
            {
                MessageBox.Show("Hãy nhập số trong khoảng hợp lệ!!!");
                return;
            }
            switch (num)
            {
                case 0:
                    {
                        result.Text = "Không";
                        break;
                    }
                case 1:
                    {
                        result.Text = "Một";
                        break;
                    }
                case 2:
                    {
                        result.Text = "Hai";
                        break;
                    }
                case 3:
                    {
                        result.Text = "Ba";
                        break;
                    }
                case 4:
                    {
                        result.Text = "Bốn";
                        break;
                    }
                case 5:
                    {
                        result.Text = "Năm";
                        break;
                    }
                case 6:
                    {
                        result.Text = "Sáu";
                        break;
                    }
                case 7:
                    {
                        result.Text = "Bảy";
                        break;
                    }
                case 8:
                    {
                        result.Text = "Tám";
                        break;
                    }
                case 9:
                    {
                        result.Text = "Chín";
                        break;
                    }
                default:
                    break;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number.Text = "";
            result.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
