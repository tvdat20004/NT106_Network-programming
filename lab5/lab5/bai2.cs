using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;
using MailKit;
using MailKit.Search;
using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MailKit.Security;
namespace lab5
{
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            using (var client = new ImapClient())
            {
                client.Connect("127.0.0.1", 143, SecureSocketOptions.None);

                client.Authenticate(Email.Text, Password.Text);
                listView1.Columns.Add("Email", 200);
                listView1.Columns.Add("From", 100);
                listView1.Columns.Add("Thời gian", 100);
                listView1.View = View.Details;
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                Recent.Text = inbox.Count.ToString();
                Total.Text = inbox.Count.ToString();

                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    ListViewItem name = new ListViewItem(message.Subject);

                    ListViewItem.ListViewSubItem from = new ListViewItem.ListViewSubItem(name, message.From.ToString());
                    name.SubItems.Add(from);

                    ListViewItem.ListViewSubItem date = new ListViewItem.ListViewSubItem(name, message.Date.Date.ToString());
                    name.SubItems.Add(date);
                    listView1.Items.Add(name);
                }
            }
        }
    }
}
