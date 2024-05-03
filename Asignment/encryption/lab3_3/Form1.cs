using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            server c = new server();
            Task.Run(() => c.ShowDialog());
        }

        private void button2_Click(object sender, EventArgs e)
        {
             client s = new client();
            Task.Run(() => s.ShowDialog());
        }
    }
}
