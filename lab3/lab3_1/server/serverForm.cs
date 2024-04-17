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
using System.Threading;

namespace server
{
    public partial class serverForm : Form
    {
        public serverForm()
        {
            InitializeComponent();
        }
        bool isRunning;
        UdpClient s = new UdpClient();

        private void serverThread()
        {
            IPAddress ip = IPAddress.Any;
            int port = 0;
            bool valid = Int32.TryParse(textBox1.Text, out port);
            if (!valid)
            {
                MessageBox.Show("Invalid port!!!");
                return;
            }
            richTextBox1.Text = "Server is running on 127.0.0.1:" + textBox1.Text + "\n";
            isRunning = true;
            try
            {
                s = new UdpClient(port);
            }
            catch
            {
                MessageBox.Show("Please use another port!!!");
                return;
            }
            while (true)
            {
                try
                {
                    byte[] data = new byte[1024];
                    IPEndPoint client = new IPEndPoint(IPAddress.Any, 0);
                    Byte[] recv = s.Receive(ref client);
                    string message = Encoding.UTF8.GetString(recv, 0, recv.Length);
                    richTextBox1.Text += "Client " + client.ToString() + ": " + message + "\n";
                }
                catch
                {
                    return;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                MessageBox.Show("Server is already running!!!");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a port!!!");
                return;
            }
            CheckForIllegalCrossThreadCalls = false;
            Thread t = new Thread(serverThread);
            t.Start();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                s.Close();
                richTextBox1.Text += "Server stopped\n";
                isRunning = false;
            }
            else
            {
                MessageBox.Show("Server is not running!!!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
