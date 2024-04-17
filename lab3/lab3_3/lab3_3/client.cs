using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_3
{
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
        }
        TcpClient tcpClient = new TcpClient();
        NetworkStream stream = null;
        private void connectButton_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            int port = 0;
            try
            {
                ip = IPAddress.Parse(textBox1.Text);
                port = int.Parse(textBox2.Text);
            }
            catch (Exception)
            {
                richTextBox1.Text += "Invalid IP address or port\n";
                return;
            }
            IPEndPoint server = new IPEndPoint(ip, port);
            try
            { 
                tcpClient = new TcpClient();
                tcpClient.Connect(server);
                richTextBox1.Text += "Connected to server on " + ip.ToString() + ':' + port.ToString() + '\n';
            }
            catch   
            {
                MessageBox.Show("Can't connect to server!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tcpClient.Connected == false)
            {
                MessageBox.Show("Not connected to server!!!");
                return;
            }
            stream = tcpClient.GetStream();
            byte[] data = System.Text.Encoding.UTF8.GetBytes(textBox3.Text + "  \r\n");
            stream.Write(data, 0, data.Length);
            richTextBox1.Text += "Sent: " + textBox3.Text + '\n';
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tcpClient.Connected == false)
            {
                MessageBox.Show("Not connected to server!!!");
                return;
            }

            richTextBox1.Text += "Disconnected from server\n";
            stream.Close();
            tcpClient.Close();
        }
    }
}
