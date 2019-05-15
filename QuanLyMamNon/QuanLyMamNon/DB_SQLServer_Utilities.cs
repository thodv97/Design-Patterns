using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMamNon
{
    class DB_SQLServer_Utilities
    {
        public static SqlConnection GetDBConnection(string dataSource, string database, string username, string password)
        {
            //Data Source=THODOAN-PC;Initial Catalog=QuanLyManNon;Persist Security Info=True;User ID=sa;Password=***********
            string connString = @"Data Source=" + dataSource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID="
                + username + ";Password=" + password;

            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
