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
    public partial class PML_AddUser : Form
    {

        string connectionString = @"Server=projects.dimodigital.lk; Database=PML; Uid=ttm;Pwd=ttm;";
        int userId = 0;

        public PML_AddUser()
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

        private void PML_AddUser_Load(object sender, EventArgs e)
        {
            lbl_name.Text = PML_Login.chkName;
            UserGridFill();

        }

        void UserGridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("UserViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblOrder = new DataTable();
                sqlDa.Fill(dtblOrder);
                dgv_user.DataSource = dtblOrder;
                dgv_user.Columns[0].Visible = false;
            }
        }

        void UserClear()
        {
            cb_type.Text = txt_name.Text = txt_pw.Text = txt_email.Text = "";
            userId = 0;
        }

        private void btn_UserAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("UserAdd", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_UserID", userId);
                mySqlCmd.Parameters.AddWithValue("_UserType", cb_type.Text);
                mySqlCmd.Parameters.AddWithValue("_UserName", txt_name.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Password", txt_pw.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_UserEmail", txt_email.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully");
                UserGridFill();
            }

            if (txt_name.Text != "" && txt_email.Text != "")
            {
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
                Mail.toName = txt_email.Text;
                Mail.subject = "New User Credentials";
                Mail.message = "Please note that now you have access to our KHS2 Constructions Desktop Application. Your loging credentiols are as of follows. " + "\n" + "User Name : " + txt_name.Text + "\n" + " Password : " + txt_pw.Text + "\n" + "In case if you want to change your login credentials, you can do it via 'My Profile'." + "\n" + "\n" + "Thanks & Regards.";
                Mail openMail = new Mail();
                openMail.Show();

            }

            else
            {
                MessageBox.Show("Please add a new user first.");
            }

            UserClear();
        }



        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("UserDelete", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_UserID", userId);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                UserGridFill();
                UserClear();
            }
        }

        private void dgv_user_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_user.CurrentRow.Index != -1)
            {
                cb_type.Text = dgv_user.CurrentRow.Cells[1].Value.ToString();
                txt_name.Text = dgv_user.CurrentRow.Cells[2].Value.ToString();
                txt_pw.Text = dgv_user.CurrentRow.Cells[3].Value.ToString();
                txt_email.Text = dgv_user.CurrentRow.Cells[4].Value.ToString();
                userId = Convert.ToInt32(dgv_user.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("UserSearchByValue", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_UserIDSearch", txt_UserSearch.Text);
                DataTable dtblOrder = new DataTable();
                sqlDa.Fill(dtblOrder);
                dgv_user.DataSource = dtblOrder;
                dgv_user.Columns[0].Visible = false;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            UserClear();
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

        private void btn_StateMan_signOut_Click(object sender, EventArgs e)
        {
            PML_Login logout = new PML_Login();
            logout.Show();
            this.Hide();
        }

        private void btn_Supervisor_signOut_Click(object sender, EventArgs e)
        {
            PML_Login logout = new PML_Login();
            logout.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PML_Login logout = new PML_Login();
            logout.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PML_Login logout = new PML_Login();
            logout.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PML_Login logout = new PML_Login();
            logout.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
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

        private void btn_Supervisor_POHistory_Click(object sender, EventArgs e)
        {
            PML_POhistory pML_POhistory = new PML_POhistory();
            pML_POhistory.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PML_POhistory pML_POhistory = new PML_POhistory();
            pML_POhistory.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PML_POhistory pML_POhistory = new PML_POhistory();
            pML_POhistory.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PML_POhistory pML_POhistory = new PML_POhistory();
            pML_POhistory.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            PML_PlaceOrder placeOrder = new PML_PlaceOrder();
            placeOrder.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            PML_DraftPO draftPO = new PML_DraftPO();
            draftPO.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PML_DraftPO draftPO = new PML_DraftPO();
            draftPO.Show();
            this.Hide();
        }

        private void btn_Supervisor_authorizePO_Click(object sender, EventArgs e)
        {
            PML_AuthorizePO authorize = new PML_AuthorizePO();
            authorize.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PML_AuthorizePO authorize = new PML_AuthorizePO();
            authorize.Show();
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

        private void btn_Supervisor_DeliveryStatusHandle_Click(object sender, EventArgs e)
        {
            PML_PODeliveryStatus deliverystatusprocurement = new PML_PODeliveryStatus();
            deliverystatusprocurement.Show();
            this.Hide();
        }
    }
}
