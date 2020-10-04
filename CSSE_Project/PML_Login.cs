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
    public partial class PML_Login : Form
    {
        string connectionString = @"Server=projects.dimodigital.lk; Database=PML; Uid=ttm;Pwd=ttm;";
        String chkType, chkName;
        string userType;

        public PML_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            chkType = null;
            chkName = null;

            if (rb_siteMan.Checked == false & rb_supervisor.Checked == false & rb_acnt.Checked == false & rb_other.Checked == false)
            {
                MessageBox.Show("You must select a user type", "ERROR");
            }
            else if (String.IsNullOrEmpty(txt_userName.Text))
            {
                MessageBox.Show("Please enter the User Name", "ERROR");
                txt_userName.Focus();
            }
            else if (String.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Please enter the Password", "ERROR");
                txt_password.Focus();
            }


            if (rb_siteMan.Checked)
            {
                userType = rb_siteMan.Text;
            }
            if (rb_supervisor.Checked)
            {
                userType = rb_supervisor.Text;
            }
            if (rb_acnt.Checked)
            {
                userType = rb_acnt.Text;
            }
            if (rb_other.Checked)
            {
                userType = rb_other.Text;
            }


            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                String sql = "SELECT UserType, UserName FROM pml_user WHERE UserType='" + userType + "' AND UserName='" + txt_userName.Text + "' AND Password='" + txt_password.Text + "'";
                MySqlCommand mySc = new MySqlCommand(sql, mysqlCon);
                MySqlDataReader myDr = mySc.ExecuteReader();

                while (myDr.Read())
                {
                    chkName = myDr.GetValue(0).ToString();
                    chkName = myDr.GetValue(1).ToString();
                }
            }

            if (chkName == null)
            {
                MessageBox.Show("Login Failed. Please check the User Type and Credentials Again !!", "ERROR");           
            }
            else
            {
                PML_StateMan_Home openSiteHome = new PML_StateMan_Home();
                openSiteHome.Show();
                this.Hide();
            }

        }

        private void PML_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
