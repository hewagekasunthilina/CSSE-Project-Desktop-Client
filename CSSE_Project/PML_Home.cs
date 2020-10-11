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
    public partial class PML_Home : Form
    {
        public PML_Home()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PML_StateMan_Home_Load(object sender, EventArgs e)
        {
            lbl_name.Text = PML_Login.chkName;

            if (PML_Login.chkType == "Site Manager")
            {
                PML_SideNav_SiteMan sitMan = new PML_SideNav_SiteMan()
                /*{
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                }*/;

                this.pnl_HomeSideNav.Controls.Add(sitMan.pnl_sideNav);
                //sitMan.Show();
            }

            else if (PML_Login.chkType == "Supervisor")
            {
                PML_SideNav_Supervisor super = new PML_SideNav_Supervisor()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };

                this.pnl_HomeSideNav.Controls.Add(super);
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

                this.pnl_HomeSideNav.Controls.Add(admin);
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

                this.pnl_HomeSideNav.Controls.Add(acnt);
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

                this.pnl_HomeSideNav.Controls.Add(lineMan);
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

                this.pnl_HomeSideNav.Controls.Add(other);
                other.Show();
            }
        }

        private void pnl_sideNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PML_Login login = new PML_Login();
            login.Show();
            this.Hide();
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
