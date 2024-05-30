using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace lab5
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private List<string> selectedFilePaths = new List<string>();

        private void btnsend_Click(object sender, EventArgs e)
        {
            if (txtfrom.Text == "" || txtto.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Please Enter information");
                return;
            }

            Task.Run(() =>
            {
                try
                {
                    MailMessage mm = new MailMessage();

                    mm.From = new MailAddress(txtfrom.Text);
                    mm.To.Add(txtto.Text);
                    mm.Subject = txtsubject.Text;
                    mm.Body = txtcontent.Text;
                    mm.IsBodyHtml = false;

                    if (selectedFilePaths.Count > 0)
                    {
                        for (int i = 0; i < selectedFilePaths.Count; i++)
                        {
                            Attachment attachment = new Attachment(selectedFilePaths[i]);
                            mm.Attachments.Add(attachment);
                        }
                    }

                    SmtpClient sc = new SmtpClient("smtp.gmail.com");
                    sc.EnableSsl = true;
                    sc.Port = 587;
                    sc.DeliveryMethod = SmtpDeliveryMethod.Network;
                    sc.Credentials = new System.Net.NetworkCredential(txtfrom.Text, txtpassword.Text);

                    sc.Send(mm);

                    this.Invoke((MethodInvoker)delegate {
                        MessageBox.Show("Done");
                    });
                }
                catch (Exception ex)
                {
                    this.Invoke((MethodInvoker)delegate {
                        MessageBox.Show(ex.Message);
                    });
                }
            });
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnattachment_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePaths.AddRange(openFileDialog.FileNames);
            }
            for (int i = 0; i < selectedFilePaths.Count; i++)
            {
                txtpath.Text += "[+] Attach file: " + selectedFilePaths[i] + '\n';
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            selectedFilePaths.Clear();
            txtpath.Clear();
        }
    }
}
