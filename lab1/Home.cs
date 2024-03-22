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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            bai2.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai3 bai3 = new Bai3(); 
            bai3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bai4 bai4 = new bai4();
            bai4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bai5 bai5 = new bai5();
            bai5.ShowDialog();
        }
    }
}
