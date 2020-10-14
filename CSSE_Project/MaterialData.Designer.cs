namespace CSSE_Project
{
    partial class MaterialData
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
            this.MatDGView = new System.Windows.Forms.DataGridView();
            this.MatSearch = new System.Windows.Forms.Button();
            this.txtMatSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MatDGView)).BeginInit();
            this.SuspendLayout();
            // 
            // MatDGView
            // 
            this.MatDGView.AllowUserToAddRows = false;
            this.MatDGView.AllowUserToDeleteRows = false;
            this.MatDGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MatDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatDGView.Location = new System.Drawing.Point(40, 75);
            this.MatDGView.Name = "MatDGView";
            this.MatDGView.ReadOnly = true;
            this.MatDGView.Size = new System.Drawing.Size(399, 257);
            this.MatDGView.TabIndex = 0;
            this.MatDGView.DoubleClick += new System.EventHandler(this.MatDGView_DoubleClick);
            // 
            // MatSearch
            // 
            this.MatSearch.BackColor = System.Drawing.Color.Peru;
            this.MatSearch.Location = new System.Drawing.Point(319, 30);
            this.MatSearch.Name = "MatSearch";
            this.MatSearch.Size = new System.Drawing.Size(120, 30);
            this.MatSearch.TabIndex = 1;
            this.MatSearch.Text = "Search";
            this.MatSearch.UseVisualStyleBackColor = false;
            this.MatSearch.Click += new System.EventHandler(this.MatSearch_Click);
            // 
            // txtMatSearch
            // 
            this.txtMatSearch.Location = new System.Drawing.Point(40, 36);
            this.txtMatSearch.Name = "txtMatSearch";
            this.txtMatSearch.Size = new System.Drawing.Size(255, 20);
            this.txtMatSearch.TabIndex = 2;
            // 
            // MaterialData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 355);
            this.Controls.Add(this.txtMatSearch);
            this.Controls.Add(this.MatSearch);
            this.Controls.Add(this.MatDGView);
            this.Name = "MaterialData";
            this.Text = "MaterialData";
            this.Load += new System.EventHandler(this.MaterialData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MatDGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView MatDGView;
        private System.Windows.Forms.Button MatSearch;
        private System.Windows.Forms.TextBox txtMatSearch;
    }
}