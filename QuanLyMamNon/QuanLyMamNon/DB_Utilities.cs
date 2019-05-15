using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMamNon
{
    class DB_Utilities
    {
        public static SqlConnection GetDBConnection()
        {
            //Data Source=THODOAN-PC;Initial Catalog=QuanLyManNon;Persist Security Info=True;User ID=sa;Password=***********
            string dataSource = @"THODOAN-PC";
            string database = "QuanLyManNon";
            string username = "sa";
            string password = "123456";

            return DB_SQLServer_Utilities.GetDBConnection(dataSource, database, username, password);
        }
    }
}
