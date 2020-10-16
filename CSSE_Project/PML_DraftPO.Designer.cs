namespace CSSE_Project
{
    partial class PML_DraftPO
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_draft_tbl = new System.Windows.Forms.DataGridView();
            this.pnl_sideNav = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pnl_siteMan = new System.Windows.Forms.Panel();
            this.btn_draft = new System.Windows.Forms.Button();
            this.btn_placeOrder = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btn_StateMan_signOut = new System.Windows.Forms.Button();
            this.btn_StateMan_POHistory = new System.Windows.Forms.Button();
            this.btn_StateMan_createPO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_draft_tbl)).BeginInit();
            this.pnl_sideNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.pnl_siteMan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_draft_tbl
            // 
            this.dgv_draft_tbl.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_draft_tbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_draft_tbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_draft_tbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_draft_tbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_draft_tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_draft_tbl.Location = new System.Drawing.Point(296, 152);
            this.dgv_draft_tbl.Name = "dgv_draft_tbl";
            this.dgv_draft_tbl.RowHeadersWidth = 51;
            this.dgv_draft_tbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_draft_tbl.Size = new System.Drawing.Size(852, 526);
            this.dgv_draft_tbl.TabIndex = 28;
            this.dgv_draft_tbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_draft_tbl_CellClick);
            this.dgv_draft_tbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_draft_tbl_CellContentClick);
            this.dgv_draft_tbl.Click += new System.EventHandler(this.Dgv_draft_tbl_Click);
            this.dgv_draft_tbl.DoubleClick += new System.EventHandler(this.Dgv_draft_tbl_DoubleClick);
            // 
            // pnl_sideNav
            // 
            this.pnl_sideNav.BackColor = System.Drawing.Color.Peru;
            this.pnl_sideNav.Controls.Add(this.pnl_siteMan);
            this.pnl_sideNav.Controls.Add(this.pictureBox5);
            this.pnl_sideNav.Location = new System.Drawing.Point(0, 90);
            this.pnl_sideNav.Name = "pnl_sideNav";
            this.pnl_sideNav.Size = new System.Drawing.Size(250, 610);
            this.pnl_sideNav.TabIndex = 25;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CSSE_Project.Properties.Resources.usr3;
            this.pictureBox5.Location = new System.Drawing.Point(69, 57);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(110, 110);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(130, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "KHS2 Constructions";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(1011, 35);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(42, 16);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Label";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 90);
            this.panel1.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CSSE_Project.Properties.Resources.l3;
            this.pictureBox2.Location = new System.Drawing.Point(64, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::CSSE_Project.Properties.Resources.cross;
            this.pictureBox3.Location = new System.Drawing.Point(1178, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSSE_Project.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(1119, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(620, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "Draft Purchase Orders";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CSSE_Project.Properties.Resources.goBack;
            this.pictureBox6.Location = new System.Drawing.Point(257, 97);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pnl_siteMan
            // 
            this.pnl_siteMan.BackColor = System.Drawing.Color.Peru;
            this.pnl_siteMan.Controls.Add(this.btn_draft);
            this.pnl_siteMan.Controls.Add(this.btn_placeOrder);
            this.pnl_siteMan.Controls.Add(this.lblName);
            this.pnl_siteMan.Controls.Add(this.btn_StateMan_signOut);
            this.pnl_siteMan.Controls.Add(this.btn_StateMan_POHistory);
            this.pnl_siteMan.Controls.Add(this.btn_StateMan_createPO);
            this.pnl_siteMan.Location = new System.Drawing.Point(0, 170);
            this.pnl_siteMan.Name = "pnl_siteMan";
            this.pnl_siteMan.Size = new System.Drawing.Size(250, 400);
            this.pnl_siteMan.TabIndex = 45;
            // 
            // btn_draft
            // 
            this.btn_draft.BackColor = System.Drawing.Color.Transparent;
            this.btn_draft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_draft.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_draft.FlatAppearance.BorderSize = 0;
            this.btn_draft.FlatAppearance.CheckedBackColor = System.Drawing.Color.Tan;
            this.btn_draft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.btn_draft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_draft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_draft.ForeColor = System.Drawing.Color.White;
            this.btn_draft.Image = global::CSSE_Project.Properties.Resources.draft;
            this.btn_draft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_draft.Location = new System.Drawing.Point(0, 265);
            this.btn_draft.Name = "btn_draft";
            this.btn_draft.Size = new System.Drawing.Size(250, 50);
            this.btn_draft.TabIndex = 7;
            this.btn_draft.Text = "Draft PO";
            this.btn_draft.UseVisualStyleBackColor = false;
            this.btn_draft.Click += new System.EventHandler(this.btn_draft_Click);
            // 
            // btn_placeOrder
            // 
            this.btn_placeOrder.BackColor = System.Drawing.Color.Transparent;
            this.btn_placeOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_placeOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_placeOrder.FlatAppearance.BorderSize = 0;
            this.btn_placeOrder.FlatAppearance.CheckedBackColor = System.Drawing.Color.Tan;
            this.btn_placeOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.btn_placeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_placeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_placeOrder.ForeColor = System.Drawing.Color.White;
            this.btn_placeOrder.Image = global::CSSE_Project.Properties.Resources.place_order;
            this.btn_placeOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_placeOrder.Location = new System.Drawing.Point(0, 216);
            this.btn_placeOrder.Name = "btn_placeOrder";
            this.btn_placeOrder.Size = new System.Drawing.Size(250, 50);
            this.btn_placeOrder.TabIndex = 6;
            this.btn_placeOrder.Text = "Place Order";
            this.btn_placeOrder.UseVisualStyleBackColor = false;
            this.btn_placeOrder.Click += new System.EventHandler(this.btn_placeOrder_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(54, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(140, 25);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Site Manager";
            // 
            // btn_StateMan_signOut
            // 
            this.btn_StateMan_signOut.BackColor = System.Drawing.Color.Transparent;
            this.btn_StateMan_signOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_StateMan_signOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_StateMan_signOut.FlatAppearance.BorderSize = 0;
            this.btn_StateMan_signOut.FlatAppearance.CheckedBackColor = System.Drawing.Color.Tan;
            this.btn_StateMan_signOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.btn_StateMan_signOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StateMan_signOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StateMan_signOut.ForeColor = System.Drawing.Color.White;
            this.btn_StateMan_signOut.Image = global::CSSE_Project.Properties.Resources.logout;
            this.btn_StateMan_signOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_StateMan_signOut.Location = new System.Drawing.Point(0, 69);
            this.btn_StateMan_signOut.Name = "btn_StateMan_signOut";
            this.btn_StateMan_signOut.Size = new System.Drawing.Size(250, 50);
            this.btn_StateMan_signOut.TabIndex = 3;
            this.btn_StateMan_signOut.Text = "Sign Out";
            this.btn_StateMan_signOut.UseVisualStyleBackColor = false;
            this.btn_StateMan_signOut.Click += new System.EventHandler(this.btn_StateMan_signOut_Click);
            // 
            // btn_StateMan_POHistory
            // 
            this.btn_StateMan_POHistory.BackColor = System.Drawing.Color.Transparent;
            this.btn_StateMan_POHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_StateMan_POHistory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_StateMan_POHistory.FlatAppearance.BorderSize = 0;
            this.btn_StateMan_POHistory.FlatAppearance.CheckedBackColor = System.Drawing.Color.Tan;
            this.btn_StateMan_POHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.btn_StateMan_POHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StateMan_POHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StateMan_POHistory.ForeColor = System.Drawing.Color.White;
            this.btn_StateMan_POHistory.Image = global::CSSE_Project.Properties.Resources.order_history;
            this.btn_StateMan_POHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_StateMan_POHistory.Location = new System.Drawing.Point(0, 167);
            this.btn_StateMan_POHistory.Name = "btn_StateMan_POHistory";
            this.btn_StateMan_POHistory.Size = new System.Drawing.Size(250, 50);
            this.btn_StateMan_POHistory.TabIndex = 1;
            this.btn_StateMan_POHistory.Text = "PO History";
            this.btn_StateMan_POHistory.UseVisualStyleBackColor = false;
            this.btn_StateMan_POHistory.Click += new System.EventHandler(this.btn_StateMan_POHistory_Click);
            // 
            // btn_StateMan_createPO
            // 
            this.btn_StateMan_createPO.BackColor = System.Drawing.Color.Transparent;
            this.btn_StateMan_createPO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_StateMan_createPO.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_StateMan_createPO.FlatAppearance.BorderSize = 0;
            this.btn_StateMan_createPO.FlatAppearance.CheckedBackColor = System.Drawing.Color.Tan;
            this.btn_StateMan_createPO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.btn_StateMan_createPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StateMan_createPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StateMan_createPO.ForeColor = System.Drawing.Color.White;
            this.btn_StateMan_createPO.Image = global::CSSE_Project.Properties.Resources.create_order;
            this.btn_StateMan_createPO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_StateMan_createPO.Location = new System.Drawing.Point(0, 118);
            this.btn_StateMan_createPO.Name = "btn_StateMan_createPO";
            this.btn_StateMan_createPO.Size = new System.Drawing.Size(250, 50);
            this.btn_StateMan_createPO.TabIndex = 0;
            this.btn_StateMan_createPO.Text = "Create PO";
            this.btn_StateMan_createPO.UseVisualStyleBackColor = false;
            this.btn_StateMan_createPO.Click += new System.EventHandler(this.btn_StateMan_createPO_Click);
            // 
            // PML_DraftPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.dgv_draft_tbl);
            this.Controls.Add(this.pnl_sideNav);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "PML_DraftPO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PML_DraftPO";
            this.Load += new System.EventHandler(this.PML_DraftPO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_draft_tbl)).EndInit();
            this.pnl_sideNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.pnl_siteMan.ResumeLayout(false);
            this.pnl_siteMan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.DataGridView dgv_draft_tbl;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel pnl_sideNav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Panel pnl_siteMan;
        internal System.Windows.Forms.Button btn_draft;
        internal System.Windows.Forms.Button btn_placeOrder;
        private System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.Button btn_StateMan_signOut;
        internal System.Windows.Forms.Button btn_StateMan_POHistory;
        internal System.Windows.Forms.Button btn_StateMan_createPO;
    }
}