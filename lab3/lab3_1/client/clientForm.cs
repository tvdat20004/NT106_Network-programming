using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace client
{
    public partial class clientForm : Form
    {
        public clientForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            bool valid = IPAddress.TryParse(textBox1.Text, out ip);
            if (!valid)
            {
                MessageBox.Show("Invalid IP Address");
                return;
            }
            int port;
            valid = Int32.TryParse(textBox2.Text, out port);
            if (!valid)
            {
                MessageBox.Show("Invalid port");
            }
            UdpClient udpClient = new UdpClient();
            try
            {
                udpClient.Connect(ip, port);
            }
            catch
            {
                MessageBox.Show("Cannot connect to server");
                return;
            }
            Byte[] sendBytes = Encoding.UTF8.GetBytes(richTextBox1.Text);
            udpClient.Send(sendBytes, sendBytes.Length);
            richTextBox1.Clear();
        }
    }
}
