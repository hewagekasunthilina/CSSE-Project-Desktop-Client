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
        public PML_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            PML_StateMan_Home openSiteHome = new PML_StateMan_Home();
            openSiteHome.Show();
            this.Hide();
        }
    }
}
