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
using DotNetBrowser.Browser;
using DotNetBrowser.Engine;
using DotNetBrowser.WinForms;
namespace lab4
{
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
            var engineOptions = new EngineOptions.Builder
            {
                RenderingMode = RenderingMode.HardwareAccelerated,
                LicenseKey = "OK9Y20DJW3YRN8JRVP25FMJ67Q0WI59UU1DSPZYUAMOXZ6GL3FOHJ6EIAHY8276684VE0L6PLUWZZ2YJX57G9ORHNAQ41G80CLEN7644N2C34P2RTMYW4PYCIN54W01IN7L6HOLE1EM5NC40C"
            }.Build();
            engine = EngineFactory.Create(engineOptions);
            browser = engine.CreateBrowser();
            browserView1.InitializeFrom(browser);
        }
        
        WebRequest request = null;
        WebResponse response = null;
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
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            return responseFromServer;
        }
        private void rawHTML_Click(object sender, EventArgs e)
        {
            string url = urlTextBox.Text;
            if (url == "")
            {
                MessageBox.Show("Please enter a URL");
                return;
            }
            htmlTextBox.Visible = true;
            browserView1.Visible = false;
            htmlTextBox.Text = getHTML(url);
        }
        private IBrowser browser;
        private IEngine engine;
        private void renderHTML_Click(object sender, EventArgs e)
        {
            string user_agent = comboBox1.Text;
            string url = urlTextBox.Text;
            if (url == "")
            {
                MessageBox.Show("Please enter a URL");
                return;
            }
            htmlTextBox.Visible = false;
            browserView1.Visible = true;
            if (user_agent != "")
            {
                AdjustBrowserUserAgent(user_agent);
            }
            browser.Navigation.LoadUrl(url);

        }

        
        private void AdjustBrowserUserAgent(string device)
        {
            browser.UserAgent = device;

        }
        private void bai2_FormClosing(object sender, FormClosingEventArgs e)
        {
            browser?.Dispose();
            engine?.Dispose();
        }
    }
}
