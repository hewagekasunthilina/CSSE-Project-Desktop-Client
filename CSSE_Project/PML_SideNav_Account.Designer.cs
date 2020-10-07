namespace CSSE_Project
{
    partial class PML_SideNav_Account
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
            this.pnl_sideNav = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Supervisor_signOut = new System.Windows.Forms.Button();
            this.btn_Supervisor_POHistory = new System.Windows.Forms.Button();
            this.pnl_sideNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_sideNav
            // 
            this.pnl_sideNav.BackColor = System.Drawing.Color.Peru;
            this.pnl_sideNav.Controls.Add(this.label1);
            this.pnl_sideNav.Controls.Add(this.btn_Supervisor_signOut);
            this.pnl_sideNav.Controls.Add(this.btn_Supervisor_POHistory);
            this.pnl_sideNav.Location = new System.Drawing.Point(0, 0);
            this.pnl_sideNav.Name = "pnl_sideNav";
            this.pnl_sideNav.Size = new System.Drawing.Size(250, 400);
            this.pnl_sideNav.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Accounting Staff";
            // 
            // btn_Supervisor_signOut
            // 
            this.btn_Supervisor_signOut.BackColor = System.Drawing.Color.Transparent;
            this.btn_Supervisor_signOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Supervisor_signOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Supervisor_signOut.FlatAppearance.BorderSize = 0;
            this.btn_Supervisor_signOut.FlatAppearance.CheckedBackColor = System.Drawing.Color.Tan;
            this.btn_Supervisor_signOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.btn_Supervisor_signOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Supervisor_signOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Supervisor_signOut.ForeColor = System.Drawing.Color.White;
            this.btn_Supervisor_signOut.Image = global::CSSE_Project.Properties.Resources.logout;
            this.btn_Supervisor_signOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Supervisor_signOut.Location = new System.Drawing.Point(0, 69);
            this.btn_Supervisor_signOut.Name = "btn_Supervisor_signOut";
            this.btn_Supervisor_signOut.Size = new System.Drawing.Size(250, 50);
            this.btn_Supervisor_signOut.TabIndex = 3;
            this.btn_Supervisor_signOut.Text = "Sign Out";
            this.btn_Supervisor_signOut.UseVisualStyleBackColor = false;
            this.btn_Supervisor_signOut.Click += new System.EventHandler(this.btn_Supervisor_signOut_Click);
            // 
            // btn_Supervisor_POHistory
            // 
            this.btn_Supervisor_POHistory.BackColor = System.Drawing.Color.Transparent;
            this.btn_Supervisor_POHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Supervisor_POHistory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Supervisor_POHistory.FlatAppearance.BorderSize = 0;
            this.btn_Supervisor_POHistory.FlatAppearance.CheckedBackColor = System.Drawing.Color.Tan;
            this.btn_Supervisor_POHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.btn_Supervisor_POHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Supervisor_POHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Supervisor_POHistory.ForeColor = System.Drawing.Color.White;
            this.btn_Supervisor_POHistory.Image = global::CSSE_Project.Properties.Resources.order_history;
            this.btn_Supervisor_POHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Supervisor_POHistory.Location = new System.Drawing.Point(0, 119);
            this.btn_Supervisor_POHistory.Name = "btn_Supervisor_POHistory";
            this.btn_Supervisor_POHistory.Size = new System.Drawing.Size(250, 50);
            this.btn_Supervisor_POHistory.TabIndex = 1;
            this.btn_Supervisor_POHistory.Text = "PO History";
            this.btn_Supervisor_POHistory.UseVisualStyleBackColor = false;
            this.btn_Supervisor_POHistory.Click += new System.EventHandler(this.btn_Supervisor_POHistory_Click);
            // 
            // PML_SideNav_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 400);
            this.Controls.Add(this.pnl_sideNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PML_SideNav_Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PML_SideNav_Account";
            this.pnl_sideNav.ResumeLayout(false);
            this.pnl_sideNav.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_sideNav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Supervisor_signOut;
        private System.Windows.Forms.Button btn_Supervisor_POHistory;
    }
}