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
using System.Numerics;

namespace lab3_3
{
    public partial class server : Form
    {
        public server()
        {
            InitializeComponent();
        }

        public BigInteger bytes_to_long(byte[] text)
        {
            BigInteger res = 0;
            for (int i = 0; i < text.Length; i++)
            {
                res = res * 256 + text[i];
            }
            return res;
        }
        BigInteger n = BigInteger.Parse("147934078472576672534127900423890345816044750303016720785627069156454858791029625447612365080052552506588056518551239870401542828171321869237051243537803751107134022455864256004460336128633339980282332480723297685005088783456761857931056835285685437213626477194116038751068465810816909329451742094934205220473");
        BigInteger d = BigInteger.Parse("143708486899867156825690110631963301133382501915582945951400695146950555944442087738563578174489917990324986164358525510003726508011157160153453277077593943338425326857692003643390705067868234570844843693969561196416625404974231760928770722538765344078119954506582819087910020142684784601359550177770430021633");

        public BigInteger decryptRSA(BigInteger ct)
        {
            return BigInteger.ModPow(ct, d, n);
        }
        public byte[] long_to_bytes(BigInteger num)
        {
            List<byte> res = new List<byte>();
            while (num > 0)
            {
                res.Add((byte)(num % 256));
                num /= 256;
            }
            res.Reverse();
            return res.ToArray();
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
                byte[] recv = new byte[128];

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
                    byte[] encodedData = long_to_bytes(decryptRSA(bytes_to_long(recv)));
                    text += Encoding.UTF8.GetString(encodedData);
                } while (text.EndsWith("\n"));

                richTextBox1.Text += "Client " + clientSocket.RemoteEndPoint + ": " + text + "\n";
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
