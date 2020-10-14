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
    public partial class MaterialData : Form
    {
        string connectionString = @"Server=projects.dimodigital.lk; Database=PML; Uid=ttm;Pwd=ttm;";
        public MaterialData()
        {
            InitializeComponent();
        }

        void MaterialGridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("MaterialViewAll", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblOrder = new DataTable();
                sqlDa.Fill(dtblOrder);
                MatDGView.DataSource = dtblOrder;
                MatDGView.Columns[0].Visible = false;
            }
        }

        private void MatDGView_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void MaterialData_Load(object sender, EventArgs e)
        {
            MaterialGridFill();
        }

        private void MatSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("MatSearchByValue", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_MatIDSearch", txtMatSearch.Text);
                DataTable dtbord = new DataTable();
                sqlDa.Fill(dtbord);
                MatDGView.DataSource = dtbord;
                MatDGView.Columns[0].Visible = false;
            }
        }
    }
}
