namespace CSSE_Project
{
    partial class PML_CreatePO
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_sideNav = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_material = new System.Windows.Forms.ComboBox();
            this.cb_supplier = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dg_po = new System.Windows.Forms.DataGridView();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_POAdd = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_StateMan_signOut = new System.Windows.Forms.Button();
            this.btn_StateMan_goBack = new System.Windows.Forms.Button();
            this.btn_StateMan_POHistory = new System.Windows.Forms.Button();
            this.btn_StateMan_createPO = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_sideNav.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_po)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 90);
            this.panel1.TabIndex = 2;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(1011, 35);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(102, 16);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Hansika Perera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(106, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "KHS2 Constructions";
            // 
            // pnl_sideNav
            // 
            this.pnl_sideNav.BackColor = System.Drawing.Color.Peru;
            this.pnl_sideNav.Controls.Add(this.btn_StateMan_signOut);
            this.pnl_sideNav.Controls.Add(this.btn_StateMan_goBack);
            this.pnl_sideNav.Controls.Add(this.btn_StateMan_POHistory);
            this.pnl_sideNav.Controls.Add(this.btn_StateMan_createPO);
            this.pnl_sideNav.Location = new System.Drawing.Point(0, 90);
            this.pnl_sideNav.Name = "pnl_sideNav";
            this.pnl_sideNav.Size = new System.Drawing.Size(200, 610);
            this.pnl_sideNav.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_POAdd);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.txt_qty);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_price);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cb_supplier);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cb_material);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(236, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 188);
            this.panel2.TabIndex = 4;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(564, 107);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(275, 24);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Create Purchase Requisition";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Material";
            // 
            // cb_material
            // 
            this.cb_material.FormattingEnabled = true;
            this.cb_material.Location = new System.Drawing.Point(105, 21);
            this.cb_material.MaxDropDownItems = 30;
            this.cb_material.Name = "cb_material";
            this.cb_material.Size = new System.Drawing.Size(135, 21);
            this.cb_material.TabIndex = 1;
            // 
            // cb_supplier
            // 
            this.cb_supplier.FormattingEnabled = true;
            this.cb_supplier.Location = new System.Drawing.Point(424, 21);
            this.cb_supplier.MaxDropDownItems = 30;
            this.cb_supplier.Name = "cb_supplier";
            this.cb_supplier.Size = new System.Drawing.Size(135, 21);
            this.cb_supplier.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Supplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(653, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Agreed Price";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(753, 20);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(135, 20);
            this.txt_price.TabIndex = 5;
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(105, 71);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(135, 20);
            this.txt_qty.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(654, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Required Date";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(423, 70);
            this.comboBox1.MaxDropDownItems = 30;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(341, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Site";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantity";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(753, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dg_po
            // 
            this.dg_po.BackgroundColor = System.Drawing.Color.White;
            this.dg_po.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_po.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dg_po.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_po.GridColor = System.Drawing.Color.White;
            this.dg_po.Location = new System.Drawing.Point(236, 389);
            this.dg_po.Name = "dg_po";
            this.dg_po.Size = new System.Drawing.Size(752, 288);
            this.dg_po.TabIndex = 6;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.DimGray;
            this.btn_print.FlatAppearance.BorderSize = 0;
            this.btn_print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.Location = new System.Drawing.Point(1014, 456);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(130, 35);
            this.btn_print.TabIndex = 16;
            this.btn_print.Text = "PRINT";
            this.btn_print.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.DimGray;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(719, 128);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(130, 35);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.DimGray;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(392, 128);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(130, 35);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_POAdd
            // 
            this.btn_POAdd.BackColor = System.Drawing.Color.DimGray;
            this.btn_POAdd.FlatAppearance.BorderSize = 0;
            this.btn_POAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_POAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_POAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_POAdd.ForeColor = System.Drawing.Color.White;
            this.btn_POAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_POAdd.Location = new System.Drawing.Point(65, 128);
            this.btn_POAdd.Name = "btn_POAdd";
            this.btn_POAdd.Size = new System.Drawing.Size(130, 35);
            this.btn_POAdd.TabIndex = 13;
            this.btn_POAdd.Text = "ADD";
            this.btn_POAdd.UseVisualStyleBackColor = false;
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CSSE_Project.Properties.Resources.l3;
            this.pictureBox2.Location = new System.Drawing.Point(36, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
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
            // 
            // btn_StateMan_signOut
            // 
            this.btn_StateMan_signOut.BackColor = System.Drawing.Color.Transparent;
            this.btn_StateMan_signOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_StateMan_signOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_StateMan_signOut.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn_StateMan_signOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_StateMan_signOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StateMan_signOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StateMan_signOut.ForeColor = System.Drawing.Color.White;
            this.btn_StateMan_signOut.Image = global::CSSE_Project.Properties.Resources.logout;
            this.btn_StateMan_signOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_StateMan_signOut.Location = new System.Drawing.Point(-1, 88);
            this.btn_StateMan_signOut.Name = "btn_StateMan_signOut";
            this.btn_StateMan_signOut.Size = new System.Drawing.Size(202, 50);
            this.btn_StateMan_signOut.TabIndex = 7;
            this.btn_StateMan_signOut.Text = "Sign Out";
            this.btn_StateMan_signOut.UseVisualStyleBackColor = false;
            // 
            // btn_StateMan_goBack
            // 
            this.btn_StateMan_goBack.BackColor = System.Drawing.Color.Transparent;
            this.btn_StateMan_goBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_StateMan_goBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_StateMan_goBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn_StateMan_goBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_StateMan_goBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StateMan_goBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StateMan_goBack.ForeColor = System.Drawing.Color.White;
            this.btn_StateMan_goBack.Image = global::CSSE_Project.Properties.Resources.back;
            this.btn_StateMan_goBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_StateMan_goBack.Location = new System.Drawing.Point(-1, 137);
            this.btn_StateMan_goBack.Name = "btn_StateMan_goBack";
            this.btn_StateMan_goBack.Size = new System.Drawing.Size(202, 50);
            this.btn_StateMan_goBack.TabIndex = 6;
            this.btn_StateMan_goBack.Text = "Go Back";
            this.btn_StateMan_goBack.UseVisualStyleBackColor = false;
            // 
            // btn_StateMan_POHistory
            // 
            this.btn_StateMan_POHistory.BackColor = System.Drawing.Color.Transparent;
            this.btn_StateMan_POHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_StateMan_POHistory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_StateMan_POHistory.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn_StateMan_POHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_StateMan_POHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StateMan_POHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StateMan_POHistory.ForeColor = System.Drawing.Color.White;
            this.btn_StateMan_POHistory.Image = global::CSSE_Project.Properties.Resources.order_history;
            this.btn_StateMan_POHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_StateMan_POHistory.Location = new System.Drawing.Point(-1, 235);
            this.btn_StateMan_POHistory.Name = "btn_StateMan_POHistory";
            this.btn_StateMan_POHistory.Size = new System.Drawing.Size(202, 50);
            this.btn_StateMan_POHistory.TabIndex = 5;
            this.btn_StateMan_POHistory.Text = "PO History";
            this.btn_StateMan_POHistory.UseVisualStyleBackColor = false;
            // 
            // btn_StateMan_createPO
            // 
            this.btn_StateMan_createPO.BackColor = System.Drawing.Color.White;
            this.btn_StateMan_createPO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_StateMan_createPO.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_StateMan_createPO.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn_StateMan_createPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StateMan_createPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StateMan_createPO.ForeColor = System.Drawing.Color.Peru;
            this.btn_StateMan_createPO.Image = global::CSSE_Project.Properties.Resources.create_order_color;
            this.btn_StateMan_createPO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_StateMan_createPO.Location = new System.Drawing.Point(-1, 186);
            this.btn_StateMan_createPO.Name = "btn_StateMan_createPO";
            this.btn_StateMan_createPO.Size = new System.Drawing.Size(202, 50);
            this.btn_StateMan_createPO.TabIndex = 4;
            this.btn_StateMan_createPO.Text = "Create PO";
            this.btn_StateMan_createPO.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(421, 360);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 20);
            this.textBox1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(703, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PML_CreatePO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.dg_po);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_sideNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PML_CreatePO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PML_CreatePO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_sideNav.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_po)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_sideNav;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_supplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_material;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_StateMan_signOut;
        private System.Windows.Forms.Button btn_StateMan_goBack;
        private System.Windows.Forms.Button btn_StateMan_POHistory;
        private System.Windows.Forms.Button btn_StateMan_createPO;
        private System.Windows.Forms.Button btn_POAdd;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dg_po;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}