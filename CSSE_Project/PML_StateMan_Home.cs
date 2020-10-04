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
    public partial class PML_StateMan_Home : Form
    {
        public PML_StateMan_Home()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_StateMan_createPO_Click(object sender, EventArgs e)
        {
            PML_CreatePO openCreatePO = new PML_CreatePO();
            openCreatePO.Show();
            this.Hide();
        }
    }
}
