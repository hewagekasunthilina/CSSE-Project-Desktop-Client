namespace CSSE_Project
{
    partial class ComplainEmail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_email_del_status_CC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_e_del_status_PORT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_e_del_status_SMTP = new System.Windows.Forms.TextBox();
            this.chkbx_e_del_status_SSL = new System.Windows.Forms.CheckBox();
            this.btn_e_del_status_SEND = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_e_del_status_UN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_e_del_status_PW = new System.Windows.Forms.TextBox();
            this.txt_email_del_status_To = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email_del_status_Message = new System.Windows.Forms.TextBox();
            this.lbl_email_del_status_Message = new System.Windows.Forms.Label();
            this.txt_email_del_status_Subj = new System.Windows.Forms.TextBox();
            this.lbl_email_del_status_Subj = new System.Windows.Forms.Label();
            this.txt_email_del_status_ATTACH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_email_del_status_ATTACH = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CC :";
            // 
            // txt_email_del_status_CC
            // 
            this.txt_email_del_status_CC.Location = new System.Drawing.Point(103, 59);
            this.txt_email_del_status_CC.Name = "txt_email_del_status_CC";
            this.txt_email_del_status_CC.Size = new System.Drawing.Size(356, 22);
            this.txt_email_del_status_CC.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_e_del_status_PORT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_e_del_status_SMTP);
            this.groupBox1.Controls.Add(this.chkbx_e_del_status_SSL);
            this.groupBox1.Controls.Add(this.btn_e_del_status_SEND);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_e_del_status_UN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_e_del_status_PW);
            this.groupBox1.Location = new System.Drawing.Point(103, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 151);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Port :";
            // 
            // txt_e_del_status_PORT
            // 
            this.txt_e_del_status_PORT.Location = new System.Drawing.Point(115, 96);
            this.txt_e_del_status_PORT.Name = "txt_e_del_status_PORT";
            this.txt_e_del_status_PORT.ReadOnly = true;
            this.txt_e_del_status_PORT.Size = new System.Drawing.Size(81, 22);
            this.txt_e_del_status_PORT.TabIndex = 18;
            this.txt_e_del_status_PORT.Text = "587";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Smtp :";
            // 
            // txt_e_del_status_SMTP
            // 
            this.txt_e_del_status_SMTP.Location = new System.Drawing.Point(267, 96);
            this.txt_e_del_status_SMTP.Name = "txt_e_del_status_SMTP";
            this.txt_e_del_status_SMTP.ReadOnly = true;
            this.txt_e_del_status_SMTP.Size = new System.Drawing.Size(212, 22);
            this.txt_e_del_status_SMTP.TabIndex = 20;
            this.txt_e_del_status_SMTP.Text = "smtp.gmail.com";
            // 
            // chkbx_e_del_status_SSL
            // 
            this.chkbx_e_del_status_SSL.AutoSize = true;
            this.chkbx_e_del_status_SSL.Location = new System.Drawing.Point(381, 41);
            this.chkbx_e_del_status_SSL.Name = "chkbx_e_del_status_SSL";
            this.chkbx_e_del_status_SSL.Size = new System.Drawing.Size(56, 21);
            this.chkbx_e_del_status_SSL.TabIndex = 16;
            this.chkbx_e_del_status_SSL.Text = "SSL";
            this.chkbx_e_del_status_SSL.UseVisualStyleBackColor = true;
            // 
            // btn_e_del_status_SEND
            // 
            this.btn_e_del_status_SEND.Location = new System.Drawing.Point(381, 65);
            this.btn_e_del_status_SEND.Name = "btn_e_del_status_SEND";
            this.btn_e_del_status_SEND.Size = new System.Drawing.Size(98, 25);
            this.btn_e_del_status_SEND.TabIndex = 15;
            this.btn_e_del_status_SEND.Text = "SEND";
            this.btn_e_del_status_SEND.UseVisualStyleBackColor = true;
            this.btn_e_del_status_SEND.Click += new System.EventHandler(this.Btn_e_del_status_SEND_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name :";
            // 
            // txt_e_del_status_UN
            // 
            this.txt_e_del_status_UN.Location = new System.Drawing.Point(117, 40);
            this.txt_e_del_status_UN.Name = "txt_e_del_status_UN";
            this.txt_e_del_status_UN.Size = new System.Drawing.Size(239, 22);
            this.txt_e_del_status_UN.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password :";
            // 
            // txt_e_del_status_PW
            // 
            this.txt_e_del_status_PW.Location = new System.Drawing.Point(117, 68);
            this.txt_e_del_status_PW.Name = "txt_e_del_status_PW";
            this.txt_e_del_status_PW.PasswordChar = '*';
            this.txt_e_del_status_PW.Size = new System.Drawing.Size(239, 22);
            this.txt_e_del_status_PW.TabIndex = 6;
            // 
            // txt_email_del_status_To
            // 
            this.txt_email_del_status_To.Location = new System.Drawing.Point(103, 31);
            this.txt_email_del_status_To.Name = "txt_email_del_status_To";
            this.txt_email_del_status_To.Size = new System.Drawing.Size(356, 22);
            this.txt_email_del_status_To.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "To :";
            // 
            // txt_email_del_status_Message
            // 
            this.txt_email_del_status_Message.Location = new System.Drawing.Point(103, 115);
            this.txt_email_del_status_Message.Multiline = true;
            this.txt_email_del_status_Message.Name = "txt_email_del_status_Message";
            this.txt_email_del_status_Message.ReadOnly = true;
            this.txt_email_del_status_Message.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_email_del_status_Message.Size = new System.Drawing.Size(534, 194);
            this.txt_email_del_status_Message.TabIndex = 10;
            this.txt_email_del_status_Message.Text = "test";
            // 
            // lbl_email_del_status_Message
            // 
            this.lbl_email_del_status_Message.AutoSize = true;
            this.lbl_email_del_status_Message.Location = new System.Drawing.Point(11, 118);
            this.lbl_email_del_status_Message.Name = "lbl_email_del_status_Message";
            this.lbl_email_del_status_Message.Size = new System.Drawing.Size(73, 17);
            this.lbl_email_del_status_Message.TabIndex = 9;
            this.lbl_email_del_status_Message.Text = "Message :";
            // 
            // txt_email_del_status_Subj
            // 
            this.txt_email_del_status_Subj.Location = new System.Drawing.Point(103, 87);
            this.txt_email_del_status_Subj.Name = "txt_email_del_status_Subj";
            this.txt_email_del_status_Subj.ReadOnly = true;
            this.txt_email_del_status_Subj.Size = new System.Drawing.Size(356, 22);
            this.txt_email_del_status_Subj.TabIndex = 14;
            this.txt_email_del_status_Subj.Text = "KHS2 Constructions Delivary Complain";
            // 
            // lbl_email_del_status_Subj
            // 
            this.lbl_email_del_status_Subj.AutoSize = true;
            this.lbl_email_del_status_Subj.Location = new System.Drawing.Point(11, 92);
            this.lbl_email_del_status_Subj.Name = "lbl_email_del_status_Subj";
            this.lbl_email_del_status_Subj.Size = new System.Drawing.Size(63, 17);
            this.lbl_email_del_status_Subj.TabIndex = 13;
            this.lbl_email_del_status_Subj.Text = "Subject :";
            // 
            // txt_email_del_status_ATTACH
            // 
            this.txt_email_del_status_ATTACH.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.txt_email_del_status_ATTACH.Location = new System.Drawing.Point(103, 315);
            this.txt_email_del_status_ATTACH.Name = "txt_email_del_status_ATTACH";
            this.txt_email_del_status_ATTACH.Size = new System.Drawing.Size(278, 22);
            this.txt_email_del_status_ATTACH.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Attach File :";
            // 
            // btn_email_del_status_ATTACH
            // 
            this.btn_email_del_status_ATTACH.Location = new System.Drawing.Point(404, 314);
            this.btn_email_del_status_ATTACH.Name = "btn_email_del_status_ATTACH";
            this.btn_email_del_status_ATTACH.Size = new System.Drawing.Size(118, 25);
            this.btn_email_del_status_ATTACH.TabIndex = 21;
            this.btn_email_del_status_ATTACH.Text = "ATTACH FILE";
            this.btn_email_del_status_ATTACH.UseVisualStyleBackColor = true;
            this.btn_email_del_status_ATTACH.Click += new System.EventHandler(this.Btn_email_del_status_ATTACH_Click);
            // 
            // ComplainEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 589);
            this.Controls.Add(this.btn_email_del_status_ATTACH);
            this.Controls.Add(this.txt_email_del_status_ATTACH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_email_del_status_Subj);
            this.Controls.Add(this.lbl_email_del_status_Subj);
            this.Controls.Add(this.txt_email_del_status_Message);
            this.Controls.Add(this.lbl_email_del_status_Message);
            this.Controls.Add(this.txt_email_del_status_To);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_email_del_status_CC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ComplainEmail";
            this.Text = "ComplainEmail";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_e_del_status_SEND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_email_del_status_Message;
        private System.Windows.Forms.Label lbl_email_del_status_Subj;
        public System.Windows.Forms.TextBox txt_email_del_status_CC;
        public System.Windows.Forms.TextBox txt_e_del_status_PORT;
        public System.Windows.Forms.TextBox txt_e_del_status_SMTP;
        public System.Windows.Forms.CheckBox chkbx_e_del_status_SSL;
        public System.Windows.Forms.TextBox txt_e_del_status_UN;
        public System.Windows.Forms.TextBox txt_e_del_status_PW;
        public System.Windows.Forms.TextBox txt_email_del_status_To;
        public System.Windows.Forms.TextBox txt_email_del_status_Message;
        public System.Windows.Forms.TextBox txt_email_del_status_Subj;
        public System.Windows.Forms.TextBox txt_email_del_status_ATTACH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_email_del_status_ATTACH;
    }
}