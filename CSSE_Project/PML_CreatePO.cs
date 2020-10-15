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
        public int orderId = 0;
        string userMail = null;
        string RefNumber = null;



        public static string priceAmount;

        public PML_CreatePO()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PML_CreatePO_Load(object sender, EventArgs e)
        {
            OrderGridFill();
            
            lbl_name.Text = PML_Login.chkName;
            priceAmount = txt_price.Text;

            if (PML_Login.chkType == "Site Manager")
            {
                PML_SideNav_SiteMan sitMan = new PML_SideNav_SiteMan();
                this.pnl_CreatePO_SideNav.Controls.Add(sitMan.pnl_sideNav);
            }

            else if (PML_Login.chkType == "Supervisor")
            {
                PML_SideNav_Supervisor super = new PML_SideNav_Supervisor();
                this.pnl_CreatePO_SideNav.Controls.Add(super.pnl_sideNav);
            }

            else if (PML_Login.chkType == "Admin")
            {
                PML_SideNav_Admin admin = new PML_SideNav_Admin();
                this.pnl_CreatePO_SideNav.Controls.Add(admin.pnl_sideNav);
            }

            else if (PML_Login.chkType == "Accounting Staff")
            {
                PML_SideNav_Account acnt = new PML_SideNav_Account();
                this.pnl_CreatePO_SideNav.Controls.Add(acnt.pnl_sideNav);
            }

            else if (PML_Login.chkType == "Line Manager")
            {
                PML_SideNav_LineMan lineMan = new PML_SideNav_LineMan();
                this.pnl_CreatePO_SideNav.Controls.Add(lineMan.pnl_sideNav);
            }

            else
            {
                PML_SideNav_Other other = new PML_SideNav_Other();
                this.pnl_CreatePO_SideNav.Controls.Add(other.pnl_sideNav);
            }
        }

        private void btn_POAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                String sql = "SELECT Email FROM pml_user WHERE Username='" + lbl_name.Text + "'";
                MySqlCommand mySc = new MySqlCommand(sql, mysqlCon);
                MySqlDataReader myDr = mySc.ExecuteReader();

                while (myDr.Read())
                {
                    userMail = myDr.GetValue(0).ToString();

                }
            }

            
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

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
                    Mail mail = new Mail();
                    Mail.toName = "sashinkakumarage@gmail.com";
                    Mail.ccName = "hashithilanka@gmail.com";
                    Mail.subject = "Request Approval for Purchase Order";
                    Mail.message = "Dear Sir, I would like to kindly ask for your approval to the purchase order under the reference number " + txt_refNo.Text + ". I appreciate your prompt response for my request. Thank You";
                    Mail.userEmail = userMail;
                        mail.Show();
                        this.Hide();
                    OrderClear();

                }
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
                dg_po.Columns[10].Visible = false;
                dg_po.Columns[11].Visible = false;
                dg_po.Columns[12].Visible = false;
                dg_po.Columns[13].Visible = false;
                dg_po.Columns[14].Visible = false;
                dg_po.Columns[15].Visible = false;
                dg_po.Columns[16].Visible = false;
                dg_po.Columns[17].Visible = false;
            }
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

       

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            PML_Home home = new PML_Home();
            home.Show();
            this.Hide();
        }

        private void txt_refNo_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("select ifnull(max(cast(OrderID as int)),0)+1 from purchase_order", mysqlCon);
                DataTable dtblOrder = new DataTable();
                sqlDa.Fill(dtblOrder);
                txt_refNo.Text = dtblOrder.Rows[0][0].ToString();
                this.ActiveControl = txt_refNo;

                txt_refNo.Text = "KHS2000" + txt_refNo.Text;
            }
        }

        


        public void txt_price_Click(object sender, EventArgs e)
        {
            SupplierData sdata = new SupplierData();
            sdata.ShowDialog();
            txt_price.Text = sdata.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cb_supplier.Text = sdata.dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PML_UserProfile userProfile = new PML_UserProfile();
            userProfile.Show();
            this.Hide();
        }

        private void cb_material_DoubleClick(object sender, EventArgs e)
        {
            MaterialData mdata = new MaterialData();
            mdata.ShowDialog();
            cb_material.Text = mdata.MatDGView.CurrentRow.Cells[1].Value.ToString();
            txt_Description.Text = mdata.MatDGView.CurrentRow.Cells[2].Value.ToString();
        }

        private void cb_supplier_DoubleClick(object sender, EventArgs e)
        {
            SupplierData sdata = new SupplierData();
            sdata.ShowDialog();
            txt_price.Text = sdata.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cb_supplier.Text = sdata.dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnSiteAdd_Click(object sender, EventArgs e)
        {
            cmb_site.Text = "";
            foreach (object sites in listBoxSite.SelectedItems)
            {
                cmb_site.Text += (cmb_site.Text == "" ? "" : ",") + sites.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PML_Login login = new PML_Login();
            login.Show();
            this.Hide();
        }
    }
}
    

