using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;


namespace API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private class trendingVideo
        {
            public string Top { get; set; }
            public string Title { get; set; }
            public Image Thumbnail { get; set; }
            
            public trendingVideo(int top,string title , Image thumbnailImg)
            {
                this.Top = top.ToString();
                this.Title = title;
                this.Thumbnail = thumbnailImg;
            }
        }
        private string getHTML(string szUrl)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(szUrl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            return responseFromServer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string apiKey = "AIzaSyAfyod1zS_f7BjYiTKNMooVW2DaENPriw8";
            string url = "https://www.googleapis.com/youtube/v3/videos?part=snippet&chart=mostPopular&regionCode=VN&key=" + apiKey;
            string response = getHTML(url);
            var jsonObject = JObject.Parse(response);
            var items = jsonObject["items"].ToArray();
            int top = 1;
            List<trendingVideo> trendingVideos = new List<trendingVideo>();
            foreach (var item in items)
            {   
                string title = item["snippet"]["title"].ToString();
                string thumbnail = item["snippet"]["thumbnails"]["default"]["url"].ToString();
                Image thumbnailImg = Image.FromStream(new MemoryStream(new WebClient().DownloadData(thumbnail)));
                trendingVideo video = new trendingVideo(top, title,thumbnailImg);
                top += 1;
                trendingVideos.Add(video);
            }
            dataGridView1.DataSource = trendingVideos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }
    }
}
