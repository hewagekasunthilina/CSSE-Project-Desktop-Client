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
            lbl_name.Text = PML_Login.chkName;

            if (PML_Login.chkType == "Supervisor")
            {
                PML_SideNav_Supervisor super = new PML_SideNav_Supervisor();
                this.pnl_DraftSideNav.Controls.Add(super.pnl_sideNav);
            }

            else if (PML_Login.chkType == "Line Manager")
            {
                PML_SideNav_LineMan lineMan = new PML_SideNav_LineMan();
                this.pnl_DraftSideNav.Controls.Add(lineMan.pnl_sideNav);
            }

            else if (PML_Login.chkType == "Site Manager")
            {
                PML_SideNav_SiteMan siteMan = new PML_SideNav_SiteMan();
                this.pnl_DraftSideNav.Controls.Add(siteMan.pnl_sideNav);
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
