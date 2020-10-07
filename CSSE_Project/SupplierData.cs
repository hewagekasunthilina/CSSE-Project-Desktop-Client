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
    public partial class SupplierData : Form
    {
        
        string connectionString = @"Server=projects.dimodigital.lk; Database=PML; Uid=ttm;Pwd=ttm;";
        public SupplierData()
        {
            InitializeComponent();
        }

        void SupplieridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("OrderViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblOrder = new DataTable();
                sqlDa.Fill(dtblOrder);
                dataGridView1.DataSource = dtblOrder;
               // dataGridView1.Columns[0].Visible = false;
            }
        }

        private void SupplierData_Load(object sender, EventArgs e)
        {
            SupplieridFill();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            PML_CreatePO po = new PML_CreatePO();

            string a;
            a = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            MessageBox.Show(a);

            a = po.txt_price.Text;
            MessageBox.Show(po.txt_price.Text);


            po.ShowDialog();
           


        }

        
    }
}
