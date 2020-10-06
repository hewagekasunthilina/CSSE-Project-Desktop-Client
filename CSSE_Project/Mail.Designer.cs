namespace CSSE_Project
{
    partial class Mail
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.txt_cc = new System.Windows.Forms.TextBox();
            this.btn_SendMail = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_SSL = new System.Windows.Forms.CheckBox();
            this.txt_Smtp = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Message:";
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(153, 25);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(364, 20);
            this.txt_to.TabIndex = 4;
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(155, 139);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(364, 96);
            this.txt_msg.TabIndex = 5;
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(153, 104);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(364, 20);
            this.txt_subject.TabIndex = 6;
            // 
            // txt_cc
            // 
            this.txt_cc.Location = new System.Drawing.Point(153, 64);
            this.txt_cc.Name = "txt_cc";
            this.txt_cc.Size = new System.Drawing.Size(364, 20);
            this.txt_cc.TabIndex = 7;
            // 
            // btn_SendMail
            // 
            this.btn_SendMail.Location = new System.Drawing.Point(254, 252);
            this.btn_SendMail.Name = "btn_SendMail";
            this.btn_SendMail.Size = new System.Drawing.Size(75, 23);
            this.btn_SendMail.TabIndex = 8;
            this.btn_SendMail.Text = "SEND";
            this.btn_SendMail.UseVisualStyleBackColor = true;
            this.btn_SendMail.Click += new System.EventHandler(this.btn_SendMail_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chk_SSL);
            this.panel1.Controls.Add(this.txt_Smtp);
            this.panel1.Controls.Add(this.txt_port);
            this.panel1.Controls.Add(this.txt_pwd);
            this.panel1.Controls.Add(this.txt_UserName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(71, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 141);
            this.panel1.TabIndex = 9;
            // 
            // chk_SSL
            // 
            this.chk_SSL.AutoSize = true;
            this.chk_SSL.Location = new System.Drawing.Point(241, 57);
            this.chk_SSL.Name = "chk_SSL";
            this.chk_SSL.Size = new System.Drawing.Size(46, 17);
            this.chk_SSL.TabIndex = 9;
            this.chk_SSL.Text = "SSL";
            this.chk_SSL.UseVisualStyleBackColor = true;
            // 
            // txt_Smtp
            // 
            this.txt_Smtp.Location = new System.Drawing.Point(296, 91);
            this.txt_Smtp.Name = "txt_Smtp";
            this.txt_Smtp.Size = new System.Drawing.Size(100, 20);
            this.txt_Smtp.TabIndex = 7;
            this.txt_Smtp.Text = "smtp.gmail.com";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(108, 91);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(100, 20);
            this.txt_port.TabIndex = 6;
            this.txt_port.Text = "587";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(108, 57);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(100, 20);
            this.txt_pwd.TabIndex = 5;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(108, 22);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(100, 20);
            this.txt_UserName.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "SMTP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "UserName";
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_SendMail);
            this.Controls.Add(this.txt_cc);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mail";
            this.Text = "Mail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.TextBox txt_cc;
        private System.Windows.Forms.Button btn_SendMail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chk_SSL;
        private System.Windows.Forms.TextBox txt_Smtp;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}