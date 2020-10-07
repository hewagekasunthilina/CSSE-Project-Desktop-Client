namespace CSSE_Project
{
    partial class PML_Login
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
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_siteMan = new System.Windows.Forms.RadioButton();
            this.rb_supervisor = new System.Windows.Forms.RadioButton();
            this.rb_acnt = new System.Windows.Forms.RadioButton();
            this.rb_other = new System.Windows.Forms.RadioButton();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_manager = new System.Windows.Forms.RadioButton();
            this.rb_admin = new System.Windows.Forms.RadioButton();
            this.pnl_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Peru;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(50, 182);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(182, 42);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Sign In";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(100, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "KHS2 Constructions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "As whom you want to Sign In ?";
            // 
            // rb_siteMan
            // 
            this.rb_siteMan.AutoSize = true;
            this.rb_siteMan.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_siteMan.Location = new System.Drawing.Point(54, 156);
            this.rb_siteMan.Name = "rb_siteMan";
            this.rb_siteMan.Size = new System.Drawing.Size(104, 21);
            this.rb_siteMan.TabIndex = 5;
            this.rb_siteMan.TabStop = true;
            this.rb_siteMan.Text = "Site Manager";
            this.rb_siteMan.UseVisualStyleBackColor = true;
            // 
            // rb_supervisor
            // 
            this.rb_supervisor.AutoSize = true;
            this.rb_supervisor.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_supervisor.Location = new System.Drawing.Point(203, 156);
            this.rb_supervisor.Name = "rb_supervisor";
            this.rb_supervisor.Size = new System.Drawing.Size(88, 21);
            this.rb_supervisor.TabIndex = 6;
            this.rb_supervisor.TabStop = true;
            this.rb_supervisor.Text = "Supervisor";
            this.rb_supervisor.UseVisualStyleBackColor = true;
            // 
            // rb_acnt
            // 
            this.rb_acnt.AutoSize = true;
            this.rb_acnt.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_acnt.Location = new System.Drawing.Point(54, 181);
            this.rb_acnt.Name = "rb_acnt";
            this.rb_acnt.Size = new System.Drawing.Size(121, 21);
            this.rb_acnt.TabIndex = 7;
            this.rb_acnt.TabStop = true;
            this.rb_acnt.Text = "Accounting Staff";
            this.rb_acnt.UseVisualStyleBackColor = true;
            // 
            // rb_other
            // 
            this.rb_other.AutoSize = true;
            this.rb_other.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_other.Location = new System.Drawing.Point(324, 183);
            this.rb_other.Name = "rb_other";
            this.rb_other.Size = new System.Drawing.Size(59, 21);
            this.rb_other.TabIndex = 8;
            this.rb_other.TabStop = true;
            this.rb_other.Text = "Other";
            this.rb_other.UseVisualStyleBackColor = true;
            // 
            // pnl_login
            // 
            this.pnl_login.BackColor = System.Drawing.Color.White;
            this.pnl_login.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_login.Controls.Add(this.label4);
            this.pnl_login.Controls.Add(this.label3);
            this.pnl_login.Controls.Add(this.txt_password);
            this.pnl_login.Controls.Add(this.txt_userName);
            this.pnl_login.Controls.Add(this.btn_login);
            this.pnl_login.Location = new System.Drawing.Point(96, 282);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(285, 253);
            this.pnl_login.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(102, 116);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(149, 22);
            this.txt_password.TabIndex = 1;
            // 
            // txt_userName
            // 
            this.txt_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userName.Location = new System.Drawing.Point(102, 70);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(149, 22);
            this.txt_userName.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CSSE_Project.Properties.Resources.login_usr;
            this.pictureBox2.Location = new System.Drawing.Point(196, 241);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CSSE_Project.Properties.Resources.l3;
            this.pictureBox1.Location = new System.Drawing.Point(28, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::CSSE_Project.Properties.Resources.login_back2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(480, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 580);
            this.panel1.TabIndex = 1;
            // 
            // rb_manager
            // 
            this.rb_manager.AutoSize = true;
            this.rb_manager.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_manager.Location = new System.Drawing.Point(324, 156);
            this.rb_manager.Name = "rb_manager";
            this.rb_manager.Size = new System.Drawing.Size(106, 21);
            this.rb_manager.TabIndex = 11;
            this.rb_manager.TabStop = true;
            this.rb_manager.Text = "Line Manager";
            this.rb_manager.UseVisualStyleBackColor = true;
            // 
            // rb_admin
            // 
            this.rb_admin.AutoSize = true;
            this.rb_admin.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_admin.Location = new System.Drawing.Point(203, 183);
            this.rb_admin.Name = "rb_admin";
            this.rb_admin.Size = new System.Drawing.Size(63, 21);
            this.rb_admin.TabIndex = 12;
            this.rb_admin.TabStop = true;
            this.rb_admin.Text = "Admin";
            this.rb_admin.UseVisualStyleBackColor = true;
            // 
            // PML_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(950, 580);
            this.Controls.Add(this.rb_admin);
            this.Controls.Add(this.rb_manager);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnl_login);
            this.Controls.Add(this.rb_other);
            this.Controls.Add(this.rb_acnt);
            this.Controls.Add(this.rb_supervisor);
            this.Controls.Add(this.rb_siteMan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "PML_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.PML_Login_Load);
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_siteMan;
        private System.Windows.Forms.RadioButton rb_supervisor;
        private System.Windows.Forms.RadioButton rb_acnt;
        private System.Windows.Forms.RadioButton rb_other;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_manager;
        private System.Windows.Forms.RadioButton rb_admin;
    }
}

