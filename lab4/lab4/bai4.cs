using DotNetBrowser.Browser;
using DotNetBrowser.Engine;
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
    public partial class bai4 : Form
    {
        public bai4()
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
            browser.Navigation.NavigationFinished += Navigation_Finished;
            urlTextBox.Text = "https://www.google.com";
            request = WebRequest.Create(urlTextBox.Text);
            response = request.GetResponse();
            browser.Navigation.LoadUrl(urlTextBox.Text);
        }
        WebRequest request = null;
        WebResponse response = null;
        private IBrowser browser;
        private IEngine engine;

        private void loadButton_Click(object sender, EventArgs e)
        {
            string url = urlTextBox.Text;
            if (url == "")
            {
                MessageBox.Show("Please enter a URL");
                return;
            }
            // check if the URL is valid
            try
            {
                request = WebRequest.Create(url);
                response = request.GetResponse();
            }
            catch
            {
                url = "https://www.google.com/search?q=" + url.Replace(" ", "+");
            }
            browser.Navigation.LoadUrl(url);
        }
        private void Navigation_Finished(object sender, DotNetBrowser.Navigation.Events.NavigationFinishedEventArgs e)
        {
            // Update the urlTextBox with the current URL
            if (e.Url != "about:blank")
            {
                this.Invoke((MethodInvoker)delegate {
                    urlTextBox.Text = e.Url;
                });
            }
        }
        private void bai2_FormClosing(object sender, FormClosingEventArgs e)
        {
            browser?.Dispose();
            engine?.Dispose();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            browser.Navigation.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            browser.Navigation.GoForward();

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            loadButton_Click(sender, e);
        }
        private void urlTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Prevent the beep that occurs by default
                e.SuppressKeyPress = true;
                // Load the URL
                loadButton_Click(sender, e);
            }
        }
        private string getHTML(string url)
        {
            try
            {
                request = WebRequest.Create(url);
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
        private void downHTMLButton_Click(object sender, EventArgs e)
        {
            string html = getHTML(urlTextBox.Text);
            if (html == "")
            {
                return;
            }
            // Save the HTML to a file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, html);
            }
            MessageBox.Show("Save HTML successfully");
        }

        private void fullSrcDownloadButton_Click(object sender, EventArgs e)
        {
            string url = urlTextBox.Text;
            string html = getHTML(url);

            // Parse the HTML
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            // Find all img, script, and link elements
            var elements = doc.DocumentNode.Descendants()
                .Where(n => n.Name == "img" || n.Name == "script" || n.Name == "link");
            // Create a directory for the resources
            string domain = new Uri(url).Host;
            string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), domain);
            Directory.CreateDirectory(directoryPath);
            foreach (var element in elements)
            {
                string src = null;

                // Get the src or href attribute
                if (element.Name == "img" || element.Name == "script")
                    src = element.GetAttributeValue("src", null);
                else if (element.Name == "link")
                    src = element.GetAttributeValue("href", null);

                if (src != null)
                {
                    // Download the resource and save it to disk
                    string resourceUrl = new Uri(new Uri(url), src).AbsoluteUri;
                    Uri uriResult;
                    bool result = Uri.TryCreate(src, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
                    if (result)
                    {
                        string filename = Path.GetFileName(new Uri(src).LocalPath);
                        string path = Path.Combine(directoryPath, filename);
                        if (!string.IsNullOrEmpty(filename))
                        {
                            using (WebClient client = new WebClient())
                            {
                                client.DownloadFile(resourceUrl, path);
                            }
                        }
                    }
                    
                }
            }
            MessageBox.Show("Download full source successfully");
        }

        private void showHeaderButton_Click(object sender, EventArgs e)
        {
            
            ShowHeader showHeader = new ShowHeader(urlTextBox.Text, request, response);
            showHeader.Show();
        }
    }
}
