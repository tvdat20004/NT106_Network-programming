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

namespace lab3_4
{
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
            
        }
        TcpClient tcpClient = new TcpClient();
        NetworkStream ns = null;
        void sendMessage(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            ns.Write(data, 0, data.Length);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!tcpClient.Connected)
            {
                MessageBox.Show("Please connect to server first!!!");
                return;
            }
            string sentData = nameTextBox.Text + ": " + textBox2.Text + "\r\n";
            sendMessage(sentData);
            textBox2.Text = "";
        }
        private async void ListenForMessages()
        {
            while (tcpClient.Connected)
            {
                try
                {
                    if (ns.DataAvailable)
                    {
                        byte[] buffer = new byte[tcpClient.ReceiveBufferSize];
                        await ns.ReadAsync(buffer, 0, (int)tcpClient.ReceiveBufferSize);
                        string incomingMessage = Encoding.UTF8.GetString(buffer);
                        richTextBox1.Text += $"{incomingMessage}\n";
                    }
                }
                catch 
                {
                    return; 
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Please enter your name!!!");
                return;
            }
            IPEndPoint server = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            try
            {
                tcpClient = new TcpClient();
                tcpClient.Connect(server);
                ns = tcpClient.GetStream();
            }
            catch
            {
                MessageBox.Show("Can't connect to server!!!");
                return;
            }
            
            sendMessage(nameTextBox.Text + " just join in the chat room!!\r\n");
            await Task.Run(() => ListenForMessages());
        }

        private void disconnect(object sender, FormClosedEventArgs e)
        {
            if (tcpClient.Connected)
            {
                sendMessage(nameTextBox.Text + " just left!!\r\n");
                tcpClient.Close();
                ns.Close();
            }
        }
    }
}
