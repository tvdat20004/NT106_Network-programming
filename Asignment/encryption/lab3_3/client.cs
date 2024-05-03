using System;
using System.Numerics;
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
        BigInteger n = BigInteger.Parse("147934078472576672534127900423890345816044750303016720785627069156454858791029625447612365080052552506588056518551239870401542828171321869237051243537803751107134022455864256004460336128633339980282332480723297685005088783456761857931056835285685437213626477194116038751068465810816909329451742094934205220473");
        BigInteger e = BigInteger.Parse("65537");
        private BigInteger encryptRSA(BigInteger pt)
        {
            return BigInteger.ModPow(pt, e, n);
        }
        // convert a byte array to number (big endian)
        public BigInteger bytes_to_long(byte[] text)
        {
            BigInteger res = 0;
            for (int i = 0; i < text.Length; i++)
            {
                res = res * 256 + text[i];
            }
            return res;
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
            
            byte[] data = System.Text.Encoding.UTF8.GetBytes(textBox3.Text);
            BigInteger ct = 0;
            ct = encryptRSA(bytes_to_long(data));
            if (ct > n)
            {
                MessageBox.Show("Message is too long!!!");
                return;
            }
            byte[] ciphertext = long_to_bytes(ct);
            stream.Write(ciphertext, 0, ciphertext.Length);
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
