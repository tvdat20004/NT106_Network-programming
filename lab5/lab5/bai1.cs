using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab5
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                if (fromTextBox.Text == "" || toTextbox.Text == "" || pwTextBox.Text == "" || subjectTextBox.Text == "" || richTextBox1.Text == "")
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }
                string mailfrom = fromTextBox.Text.ToString().Trim();
                string[] mailto = toTextbox.Text.ToString().Trim().Split(',');
                string password = pwTextBox.Text.ToString().Trim();
                var basicCredential = new NetworkCredential(mailfrom, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailfrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;
                    message.From = fromAddress;
                    message.Subject = subjectTextBox.Text.ToString().Trim();
                    message.IsBodyHtml = true;
                    message.Body = richTextBox1.Text.ToString();
                    foreach (string mail in mailto)
                    {
                        message.To.Add(mail);
                    }
                    try
                    {
                        smtpClient.Send(message);
                        MessageBox.Show("Mail sent successfully");

                    }
                    catch
                    {
                        MessageBox.Show("Fail to send mail!!!");
                    }
                    
                }
            }
        }
    }
}
