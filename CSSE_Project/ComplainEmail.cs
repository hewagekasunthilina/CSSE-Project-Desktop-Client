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
    public partial class ComplainEmail : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        String path;
        public ComplainEmail()
        {
            InitializeComponent();
        }

        private void Btn_e_del_status_SEND_Click(object sender, EventArgs e)
        {
            Email emailcomplain = new Email();
            emailcomplain.UsernameEmail = txt_e_del_status_UN.Text;
            emailcomplain.PasswordEmail = txt_e_del_status_PW.Text;
            emailcomplain.SmtpvalueEmail = txt_e_del_status_SMTP.Text;
            emailcomplain.PortnumEmail = Convert.ToInt32(txt_e_del_status_PORT.Text);
            emailcomplain.SSL_boxEmail = chkbx_e_del_status_SSL.Checked;
            emailcomplain.ToEmail = txt_email_del_status_To.Text;
            emailcomplain.CcEmail = txt_email_del_status_CC.Text;
            emailcomplain.SubjectEmail = txt_email_del_status_Subj.Text;
            emailcomplain.MessageEmail = txt_email_del_status_Message.Text;
            emailcomplain.Mypath = path;
            emailcomplain.SendEmail();
        }

        private void Btn_email_del_status_ATTACH_Click(object sender, EventArgs e)
        {
            OpenFileDialog dg =new OpenFileDialog();
            if (dg.ShowDialog() == DialogResult.OK)
            {
                path = dg.FileName.ToString();
                txt_email_del_status_ATTACH.Text = path;
            }
        }

    }
}
