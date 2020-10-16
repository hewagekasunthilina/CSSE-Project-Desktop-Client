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
    public partial class PML_DraftPO : Form
    {
        string connectionString = @"Server=projects.dimodigital.lk; Database=PML; Uid=ttm;Pwd=ttm;";

        String S_OrderID;
        String S_RefNo;
        String S_Material;
        String S_Description;
        String S_Supplier;
        String S_Price;
        String S_Quantity;
        String S_Site;

        public PML_DraftPO()
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

        private void PML_DraftPO_Load(object sender, EventArgs e)
        {
            Draft_gridFill();
            lbl_name.Text = PML_Login.chkName;

            if (PML_Login.chkType == "Supervisor")
            {
                lblName.Text = "Supervisor";
            }

            else if (PML_Login.chkType == "Line Manager")
            {
                lblName.Text = "Line Manager";
            }

        }
        public void Draft_gridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter mySqlData = new MySqlDataAdapter("View_DRAFT", mysqlCon);
                mySqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable datatable = new DataTable();
                mySqlData.Fill(datatable);
                dgv_draft_tbl.DataSource = datatable;
            }
        }

        private void Dgv_draft_tbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dgv_draft_tbl_Click(object sender, EventArgs e)
        {
           //delete eka gahanna puluwan kiyala hithan imu
        }

        private void Btn_statusUpdate_Click(object sender, EventArgs e)
        {
            /*PML_CreatePO pML_CreatePO = new PML_CreatePO();
            
            pML_CreatePO.txt_refNo.Text = S_RefNo;
            pML_CreatePO.cb_material.Text = S_Material;
            pML_CreatePO.txt_Description.Text = S_Description;
            pML_CreatePO.cb_supplier.Text = S_Supplier;
            pML_CreatePO.txt_qty.Text = S_Quantity;
            pML_CreatePO.cmb_site.Text = S_Site;
            pML_CreatePO.txt_price.Text = S_Price;

            pML_CreatePO.ShowDialog();*/



        }

        private void Dgv_draft_tbl_DoubleClick(object sender, EventArgs e)
        {
            PML_CreatePO pml_create_po = new PML_CreatePO();
           

            //if (dgv_draft_tbl.CurrentRow.Index != -1)
            //{
            pml_create_po.orderId = Convert.ToInt32(dgv_draft_tbl.CurrentRow.Cells[0].Value.ToString());
            pml_create_po.txt_refNo.Text = dgv_draft_tbl.CurrentRow.Cells[1].Value.ToString();
            pml_create_po.cb_material.Text = dgv_draft_tbl.CurrentRow.Cells[2].Value.ToString();
            pml_create_po.txt_Description.Text = dgv_draft_tbl.CurrentRow.Cells[3].Value.ToString();
            pml_create_po.cb_supplier.Text = dgv_draft_tbl.CurrentRow.Cells[4].Value.ToString();
            pml_create_po.txt_price.Text = dgv_draft_tbl.CurrentRow.Cells[5].Value.ToString();
            pml_create_po.txt_qty.Text = dgv_draft_tbl.CurrentRow.Cells[6].Value.ToString();
            pml_create_po.cmb_site.Text = dgv_draft_tbl.CurrentRow.Cells[7].Value.ToString();
            //}

            MessageBox.Show(pml_create_po.txt_refNo.Text);
            pml_create_po.ShowDialog();
        }

        private void Dgv_draft_tbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }


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

        private void btn_StateMan_signOut_Click(object sender, EventArgs e)
        {
            PML_Login logout = new PML_Login();
            logout.Show();
            this.Hide();
        }

        private void btn_StateMan_POHistory_Click(object sender, EventArgs e)
        {
            PML_POhistory pML_POhistory = new PML_POhistory();
            pML_POhistory.Show();
            this.Hide();
        }

        private void btn_StateMan_createPO_Click(object sender, EventArgs e)
        {
            PML_CreatePO openCreatePO = new PML_CreatePO();
            openCreatePO.Show();
            this.Hide();
        }

        private void btn_placeOrder_Click(object sender, EventArgs e)
        {
            PML_PlaceOrder placeOrder = new PML_PlaceOrder();
            placeOrder.Show();
            this.Hide();
        }

        private void btn_draft_Click(object sender, EventArgs e)
        {
            PML_DraftPO draftPO = new PML_DraftPO();
            draftPO.Show();
            this.Hide();
        }

    }
}
