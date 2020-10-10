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
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_attachment = new System.Windows.Forms.TextBox();
            this.btn_attachment = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Message:";
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(139, 143);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(336, 20);
            this.txt_to.TabIndex = 4;
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(139, 257);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(336, 96);
            this.txt_msg.TabIndex = 5;
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(139, 222);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(336, 20);
            this.txt_subject.TabIndex = 6;
            // 
            // txt_cc
            // 
            this.txt_cc.Location = new System.Drawing.Point(139, 182);
            this.txt_cc.Name = "txt_cc";
            this.txt_cc.Size = new System.Drawing.Size(336, 20);
            this.txt_cc.TabIndex = 7;
            // 
            // btn_SendMail
            // 
            this.btn_SendMail.BackColor = System.Drawing.Color.Peru;
            this.btn_SendMail.FlatAppearance.BorderSize = 0;
            this.btn_SendMail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_SendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SendMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SendMail.ForeColor = System.Drawing.Color.White;
            this.btn_SendMail.Location = new System.Drawing.Point(207, 435);
            this.btn_SendMail.Name = "btn_SendMail";
            this.btn_SendMail.Size = new System.Drawing.Size(142, 33);
            this.btn_SendMail.TabIndex = 8;
            this.btn_SendMail.Text = "SEND";
            this.btn_SendMail.UseVisualStyleBackColor = false;
            this.btn_SendMail.Click += new System.EventHandler(this.btn_SendMail_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_pwd);
            this.panel1.Controls.Add(this.txt_UserName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(102, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 98);
            this.panel1.TabIndex = 9;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(135, 55);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(167, 20);
            this.txt_pwd.TabIndex = 5;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(135, 19);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(167, 20);
            this.txt_UserName.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email Address";
            // 
            // txt_attachment
            // 
            this.txt_attachment.Location = new System.Drawing.Point(139, 368);
            this.txt_attachment.Name = "txt_attachment";
            this.txt_attachment.Size = new System.Drawing.Size(336, 20);
            this.txt_attachment.TabIndex = 10;
            // 
            // btn_attachment
            // 
            this.btn_attachment.Location = new System.Drawing.Point(60, 366);
            this.btn_attachment.Name = "btn_attachment";
            this.btn_attachment.Size = new System.Drawing.Size(75, 23);
            this.btn_attachment.TabIndex = 11;
            this.btn_attachment.Text = "Attachment";
            this.btn_attachment.UseVisualStyleBackColor = true;
            this.btn_attachment.Click += new System.EventHandler(this.btn_attachment_Click);
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(543, 494);
            this.Controls.Add(this.btn_attachment);
            this.Controls.Add(this.btn_SendMail);
            this.Controls.Add(this.txt_attachment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_cc);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Mail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email";
            this.Load += new System.EventHandler(this.Mail_Load);
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
        public System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.TextBox txt_msg;
        public System.Windows.Forms.TextBox txt_subject;
        public System.Windows.Forms.TextBox txt_cc;
        private System.Windows.Forms.Button btn_SendMail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_attachment;
        private System.Windows.Forms.Button btn_attachment;
    }
}