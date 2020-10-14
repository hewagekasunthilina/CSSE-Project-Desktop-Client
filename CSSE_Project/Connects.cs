using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSE_Project
{
    class DBConnection
    {
        private static MySqlConnection mysqlconn;

        public static MySqlConnection getConnection()
        {
            if (mysqlconn == null)
            {
                string connectionString = @"Server=projects.dimodigital.lk; Database=PML; Uid=ttm;Pwd=ttm;";
                mysqlconn = new MySqlConnection(connectionString);
            }
            return mysqlconn;
        }

        private DBConnection() { }  //in order to use singleton

        public static void openDBConnection()
        {
            if (mysqlconn.State == ConnectionState.Closed)
            {
                mysqlconn.Open();
            }
        }

        public static void closeDBConnection()
        {
            if (mysqlconn.State == ConnectionState.Open)
            {
                mysqlconn.Close();
            }
        }
    }
}
