namespace CSSE_Project
{
    partial class PML_PlaceOrder
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
            this.btn_placeSearch = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dgv_placeOrderView = new System.Windows.Forms.DataGridView();
            this.pnl_placeOrderSideNav = new System.Windows.Forms.Panel();
            this.pnl_sideNav = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_material = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_des = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_supplier = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_site = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_po = new System.Windows.Forms.DateTimePicker();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_placeOrder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_orderStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_orderRef = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_placeOrderView)).BeginInit();
            this.pnl_sideNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_placeSearch
            // 
            this.btn_placeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_placeSearch.Location = new System.Drawing.Point(797, 157);
            this.btn_placeSearch.Name = "btn_placeSearch";
            this.btn_placeSearch.Size = new System.Drawing.Size(75, 24);
            this.btn_placeSearch.TabIndex = 28;
            this.btn_placeSearch.Text = "Search";
            this.btn_placeSearch.UseVisualStyleBackColor = true;
            this.btn_placeSearch.Click += new System.EventHandler(this.btn_placeSearch_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(587, 159);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(196, 21);
            this.txt_search.TabIndex = 27;
            // 
            // dgv_placeOrderView
            // 
            this.dgv_placeOrderView.AllowUserToAddRows = false;
            this.dgv_placeOrderView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_placeOrderView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_placeOrderView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_placeOrderView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_placeOrderView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_placeOrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_placeOrderView.Location = new System.Drawing.Point(297, 193);
            this.dgv_placeOrderView.Name = "dgv_placeOrderView";
            this.dgv_placeOrderView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_placeOrderView.Size = new System.Drawing.Size(852, 233);
            this.dgv_placeOrderView.TabIndex = 26;
            this.dgv_placeOrderView.DoubleClick += new System.EventHandler(this.dgv_placeOrderView_DoubleClick);
            // 
            // pnl_placeOrderSideNav
            // 
            this.pnl_placeOrderSideNav.Location = new System.Drawing.Point(0, 159);
            this.pnl_placeOrderSideNav.Name = "pnl_placeOrderSideNav";
            this.pnl_placeOrderSideNav.Size = new System.Drawing.Size(250, 400);
            this.pnl_placeOrderSideNav.TabIndex = 0;
            // 
            // pnl_sideNav
            // 
            this.pnl_sideNav.BackColor = System.Drawing.Color.Peru;
            this.pnl_sideNav.Controls.Add(this.pictureBox5);
            this.pnl_sideNav.Controls.Add(this.pnl_placeOrderSideNav);
            this.pnl_sideNav.Location = new System.Drawing.Point(0, 90);
            this.pnl_sideNav.Name = "pnl_sideNav";
            this.pnl_sideNav.Size = new System.Drawing.Size(250, 610);
            this.pnl_sideNav.TabIndex = 24;
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
            this.panel1.TabIndex = 23;
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
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CSSE_Project.Properties.Resources.goBack;
            this.pictureBox6.Location = new System.Drawing.Point(257, 97);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txt_material);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_des);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_supplier);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_site);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtp_po);
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Controls.Add(this.btn_placeOrder);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_amount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_orderStatus);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_orderRef);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(371, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 224);
            this.panel2.TabIndex = 29;
            // 
            // txt_material
            // 
            this.txt_material.BackColor = System.Drawing.Color.White;
            this.txt_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_material.Location = new System.Drawing.Point(169, 57);
            this.txt_material.Name = "txt_material";
            this.txt_material.ReadOnly = true;
            this.txt_material.Size = new System.Drawing.Size(144, 22);
            this.txt_material.TabIndex = 24;
            this.txt_material.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Material";
            // 
            // txt_des
            // 
            this.txt_des.BackColor = System.Drawing.Color.White;
            this.txt_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_des.Location = new System.Drawing.Point(507, 57);
            this.txt_des.Name = "txt_des";
            this.txt_des.ReadOnly = true;
            this.txt_des.Size = new System.Drawing.Size(144, 22);
            this.txt_des.TabIndex = 22;
            this.txt_des.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(381, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Description";
            // 
            // txt_supplier
            // 
            this.txt_supplier.BackColor = System.Drawing.Color.White;
            this.txt_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supplier.Location = new System.Drawing.Point(169, 89);
            this.txt_supplier.Name = "txt_supplier";
            this.txt_supplier.ReadOnly = true;
            this.txt_supplier.Size = new System.Drawing.Size(144, 22);
            this.txt_supplier.TabIndex = 20;
            this.txt_supplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Supplier Name";
            // 
            // txt_site
            // 
            this.txt_site.BackColor = System.Drawing.Color.White;
            this.txt_site.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_site.Location = new System.Drawing.Point(507, 25);
            this.txt_site.Name = "txt_site";
            this.txt_site.ReadOnly = true;
            this.txt_site.Size = new System.Drawing.Size(144, 22);
            this.txt_site.TabIndex = 18;
            this.txt_site.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Construction Site";
            // 
            // dtp_po
            // 
            this.dtp_po.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_po.Location = new System.Drawing.Point(169, 121);
            this.dtp_po.Name = "dtp_po";
            this.dtp_po.Size = new System.Drawing.Size(144, 21);
            this.dtp_po.TabIndex = 16;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Peru;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(446, 175);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 35);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_placeOrder
            // 
            this.btn_placeOrder.BackColor = System.Drawing.Color.Peru;
            this.btn_placeOrder.FlatAppearance.BorderSize = 0;
            this.btn_placeOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_placeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_placeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_placeOrder.ForeColor = System.Drawing.Color.White;
            this.btn_placeOrder.Location = new System.Drawing.Point(100, 175);
            this.btn_placeOrder.Name = "btn_placeOrder";
            this.btn_placeOrder.Size = new System.Drawing.Size(150, 35);
            this.btn_placeOrder.TabIndex = 11;
            this.btn_placeOrder.Text = "PLACE";
            this.btn_placeOrder.UseVisualStyleBackColor = false;
            this.btn_placeOrder.Click += new System.EventHandler(this.btn_placeOrder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date to be Delivered";
            // 
            // txt_amount
            // 
            this.txt_amount.BackColor = System.Drawing.Color.White;
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(507, 89);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.ReadOnly = true;
            this.txt_amount.Size = new System.Drawing.Size(144, 22);
            this.txt_amount.TabIndex = 5;
            this.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(381, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Agreed Amount";
            // 
            // txt_orderStatus
            // 
            this.txt_orderStatus.BackColor = System.Drawing.Color.White;
            this.txt_orderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_orderStatus.Location = new System.Drawing.Point(507, 121);
            this.txt_orderStatus.Name = "txt_orderStatus";
            this.txt_orderStatus.ReadOnly = true;
            this.txt_orderStatus.Size = new System.Drawing.Size(144, 22);
            this.txt_orderStatus.TabIndex = 3;
            this.txt_orderStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Approved By";
            // 
            // txt_orderRef
            // 
            this.txt_orderRef.BackColor = System.Drawing.Color.White;
            this.txt_orderRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_orderRef.Location = new System.Drawing.Point(169, 25);
            this.txt_orderRef.Name = "txt_orderRef";
            this.txt_orderRef.ReadOnly = true;
            this.txt_orderRef.Size = new System.Drawing.Size(144, 22);
            this.txt_orderRef.TabIndex = 1;
            this.txt_orderRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order Reference";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(618, 110);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(216, 24);
            this.lbl_title.TabIndex = 30;
            this.lbl_title.Text = "Place Purchase Order";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PML_PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btn_placeSearch);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_placeOrderView);
            this.Controls.Add(this.pnl_sideNav);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "PML_PlaceOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PML_PlaceOrder";
            this.Load += new System.EventHandler(this.PML_PlaceOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_placeOrderView)).EndInit();
            this.pnl_sideNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_placeSearch;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView dgv_placeOrderView;
        private System.Windows.Forms.Panel pnl_placeOrderSideNav;
        private System.Windows.Forms.Panel pnl_sideNav;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_orderStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_orderRef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_placeOrder;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DateTimePicker dtp_po;
        private System.Windows.Forms.TextBox txt_supplier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_site;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_material;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.Label label9;
    }
}