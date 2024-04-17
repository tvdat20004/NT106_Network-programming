using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_3
{
    public partial class server : Form
    {
        public server()
        {
            InitializeComponent();
        }


        async void StartUnsafeThread()
        {
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip;
            int port = 0;
            try
            {
                ip = IPAddress.Parse(textBox1.Text);
                port = int.Parse(textBox2.Text);
            }
            catch (Exception)
            {
                richTextBox1.Text += "Invalid IP address or port!!!\n";
                return;
            } 
            try
            {
                IPEndPoint ipepServer = new IPEndPoint(ip, port);
                listenerSocket.Bind(ipepServer);
                listenerSocket.Listen(-1);
            }
            catch
            {
                MessageBox.Show("Can't bind to IP address and port!!!");
                return;
            }
            richTextBox1.Text += "Server is running on " + ip.ToString()+':' + port.ToString() + '\n';
            while (true)
            {
                Socket clientSocket = await listenerSocket.AcceptAsync();
                richTextBox1.Text += $"Client connected: {clientSocket.RemoteEndPoint}\n";
                HandleClient(clientSocket);
            }
        }
        void HandleClient(Socket clientSocket)
        {
            int bytesReceived = 0;
            while (true)
            {
                byte[] recv = new byte[100];

                string text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    //MessageBox.Show(bytesReceived.ToString());
                    if (bytesReceived == 0)
                    {
                        richTextBox1.Text += $"Client disconnected: {clientSocket.RemoteEndPoint}\n";
                        clientSocket.Close();
                        return;
                    }
                    text += Encoding.UTF8.GetString(recv);
                } while (text.EndsWith("\n"));
                richTextBox1.Text += "Client " + clientSocket.RemoteEndPoint + ": " + text;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
