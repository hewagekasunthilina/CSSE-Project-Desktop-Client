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
                pnl_siteMan.Left = pnl_mainSide.Left;
                pnl_siteMan.Top = pnl_mainSide.Top; 
                pnl_siteMan.Visible = true;

            }

            else if (PML_Login.chkType == "Supervisor")
            {
                pnl_sup.Left = pnl_mainSide.Left;
                pnl_sup.Top = pnl_mainSide.Top;
                pnl_sup.Visible = true;
            }

            else if (PML_Login.chkType == "Admin")
            {
                pnl_admin.Left = pnl_mainSide.Left;
                pnl_admin.Top = pnl_mainSide.Top;
                pnl_admin.Visible = true;
            }

            else if (PML_Login.chkType == "Accounting Staff")
            {
                pnl_acnt.Left = pnl_mainSide.Left;
                pnl_acnt.Top = pnl_mainSide.Top;
                pnl_acnt.Visible = true;
            }

            else if (PML_Login.chkType == "Line Manager")
            {
                pnl_line.Left = pnl_mainSide.Left;
                pnl_line.Top = pnl_mainSide.Top;
                pnl_line.Visible = true;
            }

            else
            {
                pnl_other.Left = pnl_mainSide.Left;
                pnl_other.Top = pnl_mainSide.Top;
                pnl_other.Visible = true;
            }
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

        private void btn_StateMan_signOut_Click(object sender, EventArgs e)
        {
            PML_Login logout = new PML_Login();
            logout.Show();
            this.Hide();
        }

        private void btn_StateMan_createPO_Click(object sender, EventArgs e)
        {
            PML_CreatePO openCreatePO = new PML_CreatePO();
            openCreatePO.Show();
            this.Hide();
        }

        private void btn_StateMan_POHistory_Click(object sender, EventArgs e)
        {
            PML_POhistory pML_POhistory = new PML_POhistory();
            pML_POhistory.Show();
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

        private void btn_Supervisor_signOut_Click(object sender, EventArgs e)
        {
            PML_Login login = new PML_Login();
            login.Show();
            this.Hide();
        }

        private void btn_Supervisor_authorizePO_Click(object sender, EventArgs e)
        {
            PML_AuthorizePO authorize = new PML_AuthorizePO();
            authorize.Show();
            this.Hide();
        }

        private void btn_Supervisor_POHistory_Click(object sender, EventArgs e)
        {
            PML_POhistory history = new PML_POhistory();
            history.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PML_PlaceOrder placeOrder = new PML_PlaceOrder();
            placeOrder.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PML_DraftPO draftPO = new PML_DraftPO();
            draftPO.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PML_Login login = new PML_Login();
            login.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PML_POhistory history = new PML_POhistory();
            history.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PML_Login login = new PML_Login();
            login.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PML_AuthorizePO authorize = new PML_AuthorizePO();
            authorize.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PML_POhistory history = new PML_POhistory();
            history.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PML_PlaceOrder placeOrder = new PML_PlaceOrder();
            placeOrder.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PML_DraftPO draftPO = new PML_DraftPO();
            draftPO.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PML_Login login = new PML_Login();
            login.Show();
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

        private void button10_Click(object sender, EventArgs e)
        {
            PML_POhistory history = new PML_POhistory();
            history.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            PML_Login login = new PML_Login();
            login.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            PML_POhistory history = new PML_POhistory();
            history.Show();
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
