using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSE_Project
{
    public partial class PML_PlaceOrder : Form
    {

        string connectionString = @"Server=projects.dimodigital.lk; Database=PML; Uid=ttm;Pwd=ttm;";

        int order_id = 0;

        public PML_PlaceOrder()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PML_Home home = new PML_Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PML_PlaceOrder_Load(object sender, EventArgs e)
        {
            GridFill();
            lbl_name.Text = PML_Login.chkName;

            if (PML_Login.chkType == "Supervisor")
            {
                PML_SideNav_Supervisor super = new PML_SideNav_Supervisor()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };

                this.pnl_placeOrderSideNav.Controls.Add(super);
                super.Show();
            }

            else if (PML_Login.chkType == "Line Manager")
            {
                PML_SideNav_LineMan lineMan = new PML_SideNav_LineMan()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };

                this.pnl_placeOrderSideNav.Controls.Add(lineMan);
                lineMan.Show();
            }

            else if (PML_Login.chkType == "Site Manager")
            {
                PML_SideNav_SiteMan siteMan = new PML_SideNav_SiteMan()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };

                this.pnl_placeOrderSideNav.Controls.Add(siteMan);
                siteMan.Show();
            }

        }

        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("ViewApprovedOrders", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbPlace = new DataTable();
                sqlDa.Fill(dtbPlace);
                dgv_placeOrderView.DataSource = dtbPlace;
            }

        }

        private void dgv_placeOrderView_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_placeOrderView.CurrentRow.Index != -1)
            {
                txt_orderRef.Text = dgv_placeOrderView.CurrentRow.Cells[1].Value.ToString();
                txt_amount.Text = dgv_placeOrderView.CurrentRow.Cells[6].Value.ToString();
                txt_date.Text = dgv_placeOrderView.CurrentRow.Cells[10].Value.ToString();
                txt_orderStatus.Text = dgv_placeOrderView.CurrentRow.Cells[9].Value.ToString();
                order_id = Convert.ToInt32(dgv_placeOrderView.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btn_placeOrder_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                /*mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("OrderStatusUpdateToPlaced", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Order Status Updated Successfully.");*/
            }
        }
    }
}
