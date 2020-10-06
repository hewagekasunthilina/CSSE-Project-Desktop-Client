using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace CSSE_Project
{
    public partial class PML_CreatePO : Form
    {
        string connectionString = @"Server=projects.dimodigital.lk; Database=PML; Uid=ttm;Pwd=ttm;";
        int orderId = 0;
        public PML_CreatePO()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_POAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("OrderAddOrEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_OrderID", orderId);
                mySqlCmd.Parameters.AddWithValue("_RefNo", txt_refNo.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Material", cb_material.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Description", txt_Description.Text);
                mySqlCmd.Parameters.AddWithValue("_Supplier", cb_supplier.Text);
                mySqlCmd.Parameters.AddWithValue("_Price", txt_price.Text);
                mySqlCmd.Parameters.AddWithValue("_Quantity", txt_qty.Text);
                mySqlCmd.Parameters.AddWithValue("_Site", cmb_site.Text);
                mySqlCmd.Parameters.AddWithValue("_DelDate", dateTimeReqDate.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully");
                OrderGridFill();
                OrderClear();

            }
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
                dg_po.DataSource = dtblOrder;
                dg_po.Columns[0].Visible = false;
            }
        }

        private void PML_CreatePO_Load(object sender, EventArgs e)
        {
            OrderGridFill();
            OrderClear();
        }

        void OrderClear()
        {
            txt_refNo.Text = cb_material.Text = txt_Description.Text = cb_supplier.Text = txt_price.Text = txt_qty.Text = cmb_site.Text = dateTimeReqDate.Text = "";
            orderId = 0;
            btn_POAdd.Text = "CREATE ORDER";
            btn_delete.Enabled = false;
        }

        private void dg_po_DoubleClick(object sender, EventArgs e)
        {
            if (dg_po.CurrentRow.Index != -1)
            {
                txt_refNo.Text = dg_po.CurrentRow.Cells[1].Value.ToString();
                cb_material.Text = dg_po.CurrentRow.Cells[2].Value.ToString();
                txt_Description.Text = dg_po.CurrentRow.Cells[3].Value.ToString();
                cb_supplier.Text = dg_po.CurrentRow.Cells[4].Value.ToString();
                txt_price.Text = dg_po.CurrentRow.Cells[5].Value.ToString();
                txt_qty.Text = dg_po.CurrentRow.Cells[6].Value.ToString();
                cmb_site.Text = dg_po.CurrentRow.Cells[7].Value.ToString();
                dateTimeReqDate.Text = dg_po.CurrentRow.Cells[8].Value.ToString();
                orderId = Convert.ToInt32(dg_po.CurrentRow.Cells[0].Value.ToString());
                btn_POAdd.Text = "UPDATE ORDER";
                btn_delete.Enabled = Enabled;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("OrderSearchByValue", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_OrderSearch", txt_OrderSearch.Text);
                DataTable dtblOrder = new DataTable();
                sqlDa.Fill(dtblOrder);
                dg_po.DataSource = dtblOrder;
                dg_po.Columns[0].Visible = false;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("OrderDeleteByID", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_OrderID", orderId);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                OrderGridFill();
                OrderClear();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            OrderClear();

        }

        private void buttonMail_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mail mail = new Mail();
            mail.Show();
        }

        private void createDocument()
        {
            Document document = new Document(PageSize.A2);

            PdfWriter.GetInstance(document, new FileStream("D:/PO_Report.pdf", FileMode.Create));
            document.Open();

            System.Drawing.Image PImage = System.Drawing.Image.FromFile("D:\\i1.png");
            iTextSharp.text.Image ItextImage = iTextSharp.text.Image.GetInstance(PImage, System.Drawing.Imaging.ImageFormat.Png);
            ItextImage.Alignment = Element.ALIGN_CENTER;
            document.Add(ItextImage);


            PdfPTable table = new PdfPTable(dg_po.Columns.Count);

            for(int j = 0; j < dg_po.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dg_po.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;
            

            for(int i =0; i< dg_po.Rows.Count; i++)
            {
                for(int k=0; k < dg_po.Columns.Count; k++)
                {
                    if (dg_po[k,i].Value != null)
                    {
                        table.AddCell(new Phrase(dg_po[k, i].Value.ToString()));
                    }
                }
            }

            document.Add(table);

            table.HorizontalAlignment = Element.ALIGN_CENTER;

            document.Close();

            MessageBox.Show("Document Created.");

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            createDocument();
        }
    }
}
