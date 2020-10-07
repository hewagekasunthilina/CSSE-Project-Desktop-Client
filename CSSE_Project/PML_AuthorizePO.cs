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

            if (PML_Login.chkType == "Supervisor")
            {
                PML_SideNav_Supervisor super = new PML_SideNav_Supervisor()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };

                this.pnl_AuthSideNav.Controls.Add(super);
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

                this.pnl_AuthSideNav.Controls.Add(lineMan);
                lineMan.Show();
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
            }

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
    }
}
