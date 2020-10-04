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
    }
}
