using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
            ColumnHeader stt = new ColumnHeader();
            stt.Text = "STT";
            stt.Width = 50;
            stt.AutoResize(ColumnHeaderAutoResizeStyle.None);
            listView1.Columns.Add(stt);
            ColumnHeader header = new ColumnHeader();
            header.Text = "Header";
            header.Width = 150;
            header.AutoResize(ColumnHeaderAutoResizeStyle.None);
            listView1.Columns.Add(header);

            ColumnHeader Value = new ColumnHeader();
            Value.Text = "Value";
            Value.Width = 300;
            Value.AutoResize(ColumnHeaderAutoResizeStyle.None);
            listView1.Columns.Add(Value);
            
        }
        WebRequest request = null;
        WebResponse response = null;
        // get HTML content from URL
        private void downloadButton_Click(object sender, EventArgs e)
        {
            string url = urlTextBox.Text;
            if (url == "")
            {
                MessageBox.Show("Please enter a URL");
                return;
            }
            htmlTextBox.Text = getHTML(url);
            getHeader();
        }
        private string getHTML(string url)
        {
            try
            {
                request = WebRequest.Create(url);
                // Get the response.
                response = request.GetResponse();
            }
            catch
            {
                MessageBox.Show("URL is invalid");
                response = null;
                return "";
            }
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Close the response.
            response.Close();
            return responseFromServer;
        }
        private void getHeader()
        {
            listView1.Items.Clear();
            if (response == null)
            {
                return;
            }
            int index = 1; // Start index for STT
            foreach (var header in response.Headers.AllKeys)
            {
                ListViewItem item = new ListViewItem(index.ToString());
                item.SubItems.Add(header.ToString()); // Add header name
                item.SubItems.Add(response.Headers[header].ToString()); // Add header value
                listView1.Items.Add(item);
                index++;
            }
            response.Close();
        }
    }   
}
