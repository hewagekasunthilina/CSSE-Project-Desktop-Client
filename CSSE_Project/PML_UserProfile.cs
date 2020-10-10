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
    public partial class PML_UserProfile : Form
    {

        string connectionString = @"Server=projects.dimodigital.lk; Database=PML; Uid=ttm;Pwd=ttm;";
        int userId = 0;

        public PML_UserProfile()
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

        private void PML_UserProfile_Load(object sender, EventArgs e)
        {
            lbl_name.Text = PML_Login.chkName;
            lbl_profName.Text = PML_Login.chkName;
            txt_name.Text = PML_Login.chkName;

            if (PML_Login.chkType == "Site Manager")
            {
                PML_SideNav_SiteMan sitMan = new PML_SideNav_SiteMan()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };

                this.pnl_ProfileSideNav.Controls.Add(sitMan);
                sitMan.Show();
            }

            else if (PML_Login.chkType == "Supervisor")
            {
                PML_SideNav_Supervisor super = new PML_SideNav_Supervisor()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };

                this.pnl_ProfileSideNav.Controls.Add(super);
                super.Show();
            }

            else if (PML_Login.chkType == "Admin")
            {
                PML_SideNav_Admin admin = new PML_SideNav_Admin()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };

                this.pnl_ProfileSideNav.Controls.Add(admin);
                admin.Show();
            }

            else if (PML_Login.chkType == "Accounting Staff")
            {
                PML_SideNav_Account acnt = new PML_SideNav_Account()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };

                this.pnl_ProfileSideNav.Controls.Add(acnt);
                acnt.Show();
            }

            else if (PML_Login.chkType == "Line Manager")
            {
                PML_SideNav_LineMan lineMan = new PML_SideNav_LineMan()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };

                this.pnl_ProfileSideNav.Controls.Add(lineMan);
                lineMan.Show();
            }

            else
            {
                PML_SideNav_Other other = new PML_SideNav_Other()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };

                this.pnl_ProfileSideNav.Controls.Add(other);
                other.Show();
            }

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                String sql = "SELECT Password FROM pml_user WHERE Username='" + lbl_name.Text + "'";
                MySqlCommand mySc = new MySqlCommand(sql, mysqlCon);
                MySqlDataReader myDr = mySc.ExecuteReader();

                while (myDr.Read())
                {
                    txt_pw.Text = myDr.GetValue(0).ToString();
                }
            }

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                String sql = "SELECT Email FROM pml_user WHERE Username='" + lbl_name.Text + "'";
                MySqlCommand mySc = new MySqlCommand(sql, mysqlCon);
                MySqlDataReader myDr = mySc.ExecuteReader();

                while (myDr.Read())
                {
                    txt_mail.Text = myDr.GetValue(0).ToString();
                }
            }

            txt_ID.Text = PML_Login.chkID;

        }

        private void edit_name_Click(object sender, EventArgs e)
        {
            txt_name.ReadOnly = false;
            edit_name.BackColor = Color.Peru;
        }

        private void edit_email_Click(object sender, EventArgs e)
        {
            txt_mail.ReadOnly = false;
            edit_email.BackColor = Color.Peru;
        }

        private void edit_pw_Click(object sender, EventArgs e)
        {
            txt_pw.ReadOnly = false;
            lbl_cnfrm.Visible = true;
            txt_cnfrm.Visible = true;
            edit_pw.BackColor = Color.Peru;
        }

        void UpdateProfile()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("UserProfileUpdate", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_UserID", txt_ID.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_UserName", txt_name.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Password", txt_pw.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Email", txt_mail.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("User Profile Updated Successfully");
            }
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            if (txt_pw.ReadOnly == false)
            {
                if (txt_pw.Text == txt_cnfrm.Text)
                {
                    UpdateProfile();
                    txt_cnfrm.Visible = false;
                    lbl_cnfrm.Visible = false;
                    txt_name.ReadOnly = true;
                    txt_mail.ReadOnly = true;
                    txt_pw.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Password not matched. Please check.");
                }
            }

            else
            {
                UpdateProfile();
                txt_cnfrm.Visible = false;
                lbl_cnfrm.Visible = false;
                txt_name.ReadOnly = true;
                txt_mail.ReadOnly = true;
                txt_pw.ReadOnly = true;
            }
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
