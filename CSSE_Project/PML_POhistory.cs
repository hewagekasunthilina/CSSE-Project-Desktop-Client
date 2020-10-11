using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSE_Project
{
    public partial class PML_POhistory : Form
    {

        string connectionString = @"Server=projects.dimodigital.lk; Database=PML; Uid=ttm;Pwd=ttm;";

        public PML_POhistory()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PML_Home home = new PML_Home();
            home.Show();
            this.Hide();
        }

        private void PML_POhistory_Load(object sender, EventArgs e)
        {
            lbl_name.Text = PML_Login.chkName;
            OrderGridFill();

            if (PML_Login.chkType == "Site Manager")
            {
                PML_SideNav_SiteMan sitMan = new PML_SideNav_SiteMan();
                this.pnl_POHistorySideNav.Controls.Add(sitMan.pnl_sideNav);
            }

            else if (PML_Login.chkType == "Supervisor")
            {
                PML_SideNav_Supervisor super = new PML_SideNav_Supervisor();
                this.pnl_POHistorySideNav.Controls.Add(super.pnl_sideNav);
            }

            else if (PML_Login.chkType == "Admin")
            {
                PML_SideNav_Admin admin = new PML_SideNav_Admin();
                this.pnl_POHistorySideNav.Controls.Add(admin.pnl_sideNav);
            }

            else if (PML_Login.chkType == "Accounting Staff")
            {
                PML_SideNav_Account acnt = new PML_SideNav_Account();
                this.pnl_POHistorySideNav.Controls.Add(acnt.pnl_sideNav);
            }

            else if (PML_Login.chkType == "Line Manager")
            {
                PML_SideNav_LineMan lineMan = new PML_SideNav_LineMan();
                this.pnl_POHistorySideNav.Controls.Add(lineMan.pnl_sideNav);
            }

            else
            {
                PML_SideNav_Other other = new PML_SideNav_Other();
                this.pnl_POHistorySideNav.Controls.Add(other.pnl_sideNav);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void OrderGridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("OrderViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblOrder = new DataTable();
                sqlDa.Fill(dtblOrder);
                dgv_POHistory.DataSource=dtblOrder;
                dgv_POHistory.Columns[0].Visible = false;
            }
        }

        private void btn_statusUpdate_Click(object sender, EventArgs e)
        {
            Document document = new Document(PageSize.A2);

            PdfWriter.GetInstance(document, new FileStream("E:/PO_Report.pdf", FileMode.Create));
            document.Open();

            System.Drawing.Image PImage = System.Drawing.Image.FromFile("E:\\ReportHeader.png");
            iTextSharp.text.Image ItextImage = iTextSharp.text.Image.GetInstance(PImage, System.Drawing.Imaging.ImageFormat.Png);
            ItextImage.Alignment = Element.ALIGN_CENTER;
            document.Add(ItextImage);

            
            PdfPTable table = new PdfPTable(dgv_POHistory.Columns.Count);

            for (int j = 0; j < dgv_POHistory.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dgv_POHistory.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;


            for (int i = 0; i < dgv_POHistory.Rows.Count; i++)
            {
                for (int k = 0; k < dgv_POHistory.Columns.Count; k++)
                {
                    if (dgv_POHistory[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dgv_POHistory[k, i].Value.ToString()));
                    }
                }
            }

            document.Add(table);

            table.HorizontalAlignment = Element.ALIGN_CENTER;

            document.Close();

            MessageBox.Show("Document Created.");

        }

        private void btn_POHistorySearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("OrderSearchByValue", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_OrderSearch", txt_search.Text);
                DataTable dtblOrder = new DataTable();
                sqlDa.Fill(dtblOrder);
                dgv_POHistory.DataSource = dtblOrder;
                dgv_POHistory.Columns[0].Visible = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PML_UserProfile userProfile = new PML_UserProfile();
            userProfile.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PML_Login login = new PML_Login();
            login.Show();
            this.Hide();
        }
    }
}
