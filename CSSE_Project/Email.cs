using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.ComponentModel;

namespace CSSE_Project
{
    class Email
    {
        public String usernameEmail;
        public String passwordEmail;
        public String smtpvalueEmail;
        public int portnumEmail;
        private bool sSL_boxEmail;
        public String toEmail;
        public String ccEmail;
        public String subjectEmail;
        public String messageEmail;
        private String mypath;

        public NetworkCredential login;
        public SmtpClient client;
        public MailMessage msg;

        public string UsernameEmail { get => usernameEmail; set => usernameEmail = value; }
        public string PasswordEmail { get => passwordEmail; set => passwordEmail = value; }
        public string SmtpvalueEmail { get => smtpvalueEmail; set => smtpvalueEmail = value; }
        public int PortnumEmail { get => portnumEmail; set => portnumEmail = value; }
        public string ToEmail { get => toEmail; set => toEmail = value; }
        public string CcEmail { get => ccEmail; set => ccEmail = value; }
        public string SubjectEmail { get => subjectEmail; set => subjectEmail = value; }
        public string MessageEmail { get => messageEmail; set => messageEmail = value; }
        public bool SSL_boxEmail { get => sSL_boxEmail; set => sSL_boxEmail = value; }
        public string Mypath { get => mypath; set => mypath = value; }

        public void SendEmail()
        {
            /*MessageBox.Show(UsernameEmail);
            MessageBox.Show(PasswordEmail);
            MessageBox.Show(SmtpvalueEmail);
            MessageBox.Show(PortnumEmail.ToString());
            MessageBox.Show(SSL_boxEmail.ToString() + "SSL");
            MessageBox.Show(CcEmail + "cc");
            MessageBox.Show(SubjectEmail);
            MessageBox.Show(MessageEmail);*/


            try
            {
                login = new NetworkCredential(UsernameEmail, PasswordEmail);
                client = new SmtpClient(SmtpvalueEmail);
                client.Port = PortnumEmail;
                client.EnableSsl = SSL_boxEmail;
                client.Credentials = login;
                msg = new MailMessage { From = new MailAddress("papsavindri@gmail.com", "smtp.gmail.com") };
                msg.Attachments.Add(new Attachment(mypath));
                msg.To.Add(new MailAddress(ToEmail));

                if (!string.IsNullOrEmpty(CcEmail))
                    msg.To.Add(new MailAddress(CcEmail));
                msg.Subject = SubjectEmail;
                msg.Body = MessageEmail;
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.Normal;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                string userstate = "Sending...";
                client.SendAsync(msg, userstate);
            } catch (Exception e)
            {
                MessageBox.Show("catch block"+e.ToString());
            }
            
        }

        public static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} sdend cancled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error !=null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Mail Sent Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
