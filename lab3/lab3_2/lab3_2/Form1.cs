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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Socket listenerSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

        async void StartUnsafeThread()
        {
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1);
            richTextBox1.Text += "Telnet running on 127.0.0.1:8080\n";
            while (true)
            {
                Socket clientSocket = await listenerSocket.AcceptAsync();
                richTextBox1.Text += $"Client connected: {clientSocket.RemoteEndPoint}\n";
                Thread thread = new Thread(() => HandleClient(clientSocket));
                thread.Start();
            }
        }
        void HandleClient(Socket clientSocket) 
        {
            int bytesReceived = 0;
            while (true)
            {
                byte[] recv = new byte[1];

                string text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv); 
                    if (bytesReceived == 0)
                    {
                        richTextBox1.Text += $"Client disconnected: {clientSocket.RemoteEndPoint}\n";
                        clientSocket.Close();
                        return;
                    }
                    text += Encoding.UTF8.GetString(recv);
                } while (text[text.Length - 1] != '\n');
                richTextBox1.Text += "Client " + clientSocket.RemoteEndPoint +": "+ text;
            }
        }
        bool isRunning = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                isRunning = true;
                CheckForIllegalCrossThreadCalls = false;
                Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
                serverThread.Start();
            }
            else
            {
                MessageBox.Show("Server is already running");
            }
        }
    }
}
