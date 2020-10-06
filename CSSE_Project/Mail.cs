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
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        public Mail()
        {
            InitializeComponent();
        }

        private void btn_SendMail_Click(object sender, EventArgs e)
        {
            login = new NetworkCredential(txt_UserName.Text, txt_pwd.Text);
            client = new SmtpClient(txt_Smtp.Text);
            client.Port = Convert.ToInt32(txt_port.Text);
           // client.UseDefaultCredentials = false;
            client.EnableSsl = chk_SSL.Checked;
            client.Credentials = login;
            msg = new MailMessage{From = new MailAddress(txt_UserName.Text + txt_Smtp.Text.Replace("smtp.", "@"), "sashinka kumarage", Encoding.UTF8) };
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

       

    }
}

