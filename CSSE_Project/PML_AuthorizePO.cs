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
    public partial class PML_AuthorizePO : Form
    {

        string connectionString = @"Server=projects.dimodigital.lk; Database=PML; Uid=ttm;Pwd=ttm;";

        int order_id = 0;

        public PML_AuthorizePO()
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

        private void PML_AuthorizePO_Load(object sender, EventArgs e)
        {
            lbl_name.Text = PML_Login.chkName;
            txt_updatedBy.Text = PML_Login.chkName;
            GridFill();
            Clear();

            if (PML_Login.chkType == "Supervisor")
            {
                PML_SideNav_Supervisor super = new PML_SideNav_Supervisor();
                this.pnl_AuthSideNav.Controls.Add(super.pnl_sideNav);
            }

            else if (PML_Login.chkType == "Line Manager")
            {
                PML_SideNav_LineMan lineMan = new PML_SideNav_LineMan();
                this.pnl_AuthSideNav.Controls.Add(lineMan.pnl_sideNav);
            }

        }

        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("ViewPendingOrders", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbAuth = new DataTable();
                sqlDa.Fill(dtbAuth);
                dgv_authorizeView.DataSource = dtbAuth;
                dgv_authorizeView.Columns[0].Visible = false;
            }

        }

        void Clear()
        {
            cb_status.SelectedItem = null;
            txt_orderRef.Text = "";
            txt_price.Text = "";
            txt_comment.Text = "";
            order_id = 0;
        }

        private void dgv_authorizeView_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_authorizeView.CurrentRow.Index != -1)
            {
                txt_orderRef.Text = dgv_authorizeView.CurrentRow.Cells[1].Value.ToString();
                txt_price.Text = dgv_authorizeView.CurrentRow.Cells[5].Value.ToString();
                order_id = Convert.ToInt32(dgv_authorizeView.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btn_statusUpdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                if (cb_status.SelectedIndex != -1)
                {
                    MySqlCommand cmd;
                    cmd = new MySqlCommand("UPDATE purchase_order SET Status='" + cb_status.Text + "', CheckedBy='" + txt_updatedBy.Text + "', CheckedOn='" + dtp_updatedDate.Text.Trim() + "' WHERE OrderID=@OrderID", mysqlCon);
                    mysqlCon.Open();
                    cmd.Parameters.AddWithValue("@OrderID", order_id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Status Updated Successfully");
                }
            }

            if (cb_status.Text == "Hold" && txt_orderRef.Text != "")
            {
                MessageBox.Show("Order Holded");
                string userMail = null;
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

                Mail.userEmail = userMail;
                Mail.subject = "Hold Purchase Orders";
                Mail.message = txt_orderRef.Text + "order is marked as hold order because the agreed price is not mentioned.";
                Mail openMail = new Mail();
                openMail.Show();
            }

            GridFill();
            Clear();
        }

        private void btn_authorizeSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SearchByPending", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_OrderSearch", txt_search.Text);
                DataTable dtblOrder = new DataTable();
                sqlDa.Fill(dtblOrder);
                dgv_authorizeView.DataSource = dtblOrder;
                dgv_authorizeView.Columns[0].Visible = false;
            }
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            Clear();
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
