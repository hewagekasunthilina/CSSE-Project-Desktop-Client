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
    public partial class PML_AddMaterials : Form
    {

        string connectionString = @"Server=projects.dimodigital.lk; Database=PML; Uid=ttm;Pwd=ttm;";
        int matId = 0;

        public PML_AddMaterials()
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

        private void PML_AddMaterials_Load(object sender, EventArgs e)
        {
            lbl_name.Text = PML_Login.chkName;
            MaterialGridFill();

        }

        void MaterialGridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("MaterialViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblOrder = new DataTable();
                sqlDa.Fill(dtblOrder);
                dgv_material.DataSource = dtblOrder;
                dgv_material.Columns[0].Visible = false;
            }
        }

        void MaterialClear()
        {
            txt_name.Text = txt_des.Text = "";
            matId = 0;
        }

        private void btn_MaterialAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("MaterialAdd", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_MatID", matId);
                mySqlCmd.Parameters.AddWithValue("_MatName", txt_name.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_MatDes", txt_des.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Material Added Successfully");
                MaterialGridFill();
                MaterialClear();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("MaterialDelete", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_MatID", matId);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                MaterialGridFill();
                MaterialClear();
            }
        }

        private void dgv_material_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_material.CurrentRow.Index != -1)
            {
                txt_name.Text = dgv_material.CurrentRow.Cells[1].Value.ToString();
                txt_des.Text = dgv_material.CurrentRow.Cells[2].Value.ToString();
                matId = Convert.ToInt32(dgv_material.CurrentRow.Cells[0].Value.ToString());
                btn_MaterialAdd.Text = "UPDATE";
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("MatSearchByValue", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_MatIDSearch", txt_MaterialSearch.Text);
                DataTable dtblOrder = new DataTable();
                sqlDa.Fill(dtblOrder);
                dgv_material.DataSource = dtblOrder;
                dgv_material.Columns[0].Visible = false;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            MaterialClear();
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

        private void button11_Click(object sender, EventArgs e)
        {
            PML_Login logout = new PML_Login();
            logout.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PML_POhistory pML_POhistory = new PML_POhistory();
            pML_POhistory.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            PML_AddUser addUser = new PML_AddUser();
            addUser.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            PML_AddMaterials addMaterials = new PML_AddMaterials();
            addMaterials.Show();
            this.Hide();
        }

    }
}
