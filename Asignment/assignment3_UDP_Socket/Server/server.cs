using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Server
{
    public partial class server : Form
    {
        public server()
        {
            InitializeComponent();
        }
        bool isRunning;
        private void serverThread() 
        {

            IPAddress ip = IPAddress.Any;
            int port = 0;
            bool valid = Int32.TryParse(textBox1.Text, out port);
            if (!valid)
            {
                MessageBox.Show("Invalid port!!!");
            }
            IPEndPoint IPep = new IPEndPoint(ip, port);
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            try
            {
                s.Bind(IPep);
            }
            catch
            {
                MessageBox.Show("Please use another port!!!");
                return;
            }
            while (isRunning)
            {
                byte[] data = new byte[1024];
                EndPoint client = new IPEndPoint(IPAddress.Any, 0);
                int length = s.ReceiveFrom(data, ref client);
                string message = Encoding.UTF8.GetString(data, 0, length);
                richTextBox1.Text += "Client " + client.ToString() + ": " + message + "\n";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            isRunning = true;  
            Thread t = new Thread(serverThread);
            t.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        } 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            isRunning = false;
        }
    }
}
