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
    public partial class PML_SideNav_Supervisor : Form
    {
        public PML_SideNav_Supervisor()
        {
            InitializeComponent();
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
