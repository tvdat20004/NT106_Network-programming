using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bai1 b1 = new bai1();
            b1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bai2 b2 = new bai2();   
            b2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bai3 b3 = new bai3();
            b3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bai4 b4 = new bai4();
            b4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bai5 b5 = new bai5();
            b5.ShowDialog();
        }
    }
}
