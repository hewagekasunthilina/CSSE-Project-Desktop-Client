using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;




namespace CSSE_Project
{
    public partial class Mail : Form
    {
        public static string toName;
        public static string ccName;
        public static string subject;
        public static string userEmail;
        public static string attachment;
        public static string message;

        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

        public Mail()
        {
            InitializeComponent();
            
        }

        internal void btn_SendMail_Click(object sender, EventArgs e)
        {
            


            if(txt_UserName.Text == "")
            {
                MessageBox.Show("Please Enter your Email");
            }

            else if(txt_pwd.Text == "")
            {
                MessageBox.Show("Please Enter your Password");
            }

            else if(txt_subject.Text == "")
            {
                MessageBox.Show("Please Enter a Subject");
            }

            else
            {
                login = new NetworkCredential(txt_UserName.Text, txt_pwd.Text);
                client = new SmtpClient("smtp.gmail.com");
                client.Port = Convert.ToInt32("587");
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.Credentials = login;
                msg = new MailMessage { From = new MailAddress("sashinkakumarage@gmail.com", "smtp.gmail.com") };
                if (!string.IsNullOrEmpty(txt_attachment.Text.ToString()))
                    msg.Attachments.Add(new Attachment(txt_attachment.Text.ToString()));
                msg.To.Add(new MailAddress(txt_to.Text));
                if (!string.IsNullOrEmpty(txt_cc.Text))
                    msg.To.Add(new MailAddress(txt_cc.Text));
                msg.Subject = txt_subject.Text;
                msg.Body = txt_msg.Text;
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.Normal;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                string userstate = "Sending...";
                client.SendAsync(msg, userstate);
                this.Close();
            }

        }

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Your message has been successfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_attachment_Click(object sender, EventArgs e)
        {
            OpenFileDialog dg = new OpenFileDialog();
            if (dg.ShowDialog() == DialogResult.OK)
            {
                string path = dg.FileName.ToString();
                txt_attachment.Text = path;
            }
        }

        private void Mail_Load(object sender, EventArgs e)
        {
            txt_to.Text = toName;
            txt_cc.Text = ccName;
            txt_subject.Text = subject;
            txt_UserName.Text = userEmail;
            txt_attachment.Text = attachment;
            txt_msg.Text = message;
        }
    }

}

