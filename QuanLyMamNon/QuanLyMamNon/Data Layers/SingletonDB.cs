using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyMamNon
{
    public sealed class SingletonDB
    {
        /*
         * Không cho Constructor public
         * Muốn sử dụng Class này phải thông qua 1 thực thể INSTANCE
        */
        private static volatile SqlConnection INSTANCE; // Tránh đụng độ Thread
        private static readonly object syncRoot = new object();
        private const string connectionString = @"Data Source=THODOAN-PC;Initial Catalog=QuanLyManNon;Persist Security Info=True;User ID=sa;Password=123456";

        private SingletonDB() { }

        public static SqlConnection getInstance
        {
            get
            {
                lock(syncRoot)
                {
                    if(INSTANCE == null)
                    {
                        INSTANCE = new SqlConnection(connectionString);
                    }
                }

                return INSTANCE;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private static SqlConnection conn;
        private static SqlCommand command;
        private static SqlDataAdapter adapter;
        private static DataTable dataTable;
        public static void OpenConnection()
        {
            try
            {
                conn = new SqlConnection(connectionString);

                conn.Open();
            }
            catch
            {
                MessageBox.Show("Connect failed!");
            }
        }
        public static void CloseConnection()
        {
            try
            {
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Disconnect  failed!");
            }
        }
        public static void ExcuteQuery(string query)
        {
            OpenConnection();

            command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();

            CloseConnection();
        }
        public static DataTable GetDataToDataTable(string query)
        {
            OpenConnection();

            adapter = new SqlDataAdapter(query, conn);
            dataTable = new DataTable();
            adapter.Fill(dataTable);           

            CloseConnection();
            return dataTable;
        }
        public static SqlDataReader GetDataReader(string query)
        {
            OpenConnection();
            SqlDataReader reader;
            command = new SqlCommand(query, conn);
            reader = command.ExecuteReader();

            return reader;
        }
    }
}
