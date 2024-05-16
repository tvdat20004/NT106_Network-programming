using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab4
{
    public partial class ShowHeader : Form
    {
        public ShowHeader(string url, WebRequest request, WebResponse response)
        {
            InitializeComponent();
            // Set up the columns for the requestHeaders ListView
            ColumnHeader stt = new ColumnHeader();
            stt.Text = "STT";
            stt.Width = 50;
            stt.AutoResize(ColumnHeaderAutoResizeStyle.None);
            requestHeaders.Columns.Add(stt);
            ColumnHeader header = new ColumnHeader();
            header.Text = "Header";
            header.Width = 150;
            header.AutoResize(ColumnHeaderAutoResizeStyle.None);
            requestHeaders.Columns.Add(header);

            ColumnHeader Value = new ColumnHeader();
            Value.Text = "Value";
            Value.Width = 300;
            Value.AutoResize(ColumnHeaderAutoResizeStyle.None);
            requestHeaders.Columns.Add(Value);

            // set up the columns for the responseHeaders ListView
            ColumnHeader stt1 = new ColumnHeader();
            stt1.Text = "STT";
            stt1.Width = 50;
            stt1.AutoResize(ColumnHeaderAutoResizeStyle.None);
            responseHeaders.Columns.Add(stt1);
            ColumnHeader header1 = new ColumnHeader();
            header1.Text = "Header";
            header1.Width = 150;
            header1.AutoResize(ColumnHeaderAutoResizeStyle.None);
            responseHeaders.Columns.Add(header1);

            ColumnHeader Value1 = new ColumnHeader();
            Value1.Text = "Value";
            Value1.Width = 300;
            Value1.AutoResize(ColumnHeaderAutoResizeStyle.None);
            responseHeaders.Columns.Add(Value1);
            // Get the request and response headers
            getResponseHeader(response);
            getRequestHeader(request);

        }
        private void getRequestHeader(WebRequest request)
        {
            requestHeaders.Items.Clear();
            if (request == null)
            {
                return;
            }
            int index = 1; // Start index for STT
            foreach (var header in request.Headers.AllKeys)
            {
                ListViewItem item = new ListViewItem(index.ToString());
                item.SubItems.Add(header.ToString()); // Add header name
                item.SubItems.Add(request.Headers[header].ToString()); // Add header value
                requestHeaders.Items.Add(item);
                index++;
            }
        }
        private void getResponseHeader(WebResponse response)
        {
            responseHeaders.Items.Clear();
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
                responseHeaders.Items.Add(item);
                index++;
            }
            response.Close();
        }
    }
}
