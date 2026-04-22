using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SIMS3
{
    public class DBConnect
    {
        // The database Connection
        private MySqlConnection connection = new MySqlConnection("Server=127.0.0.1; Port=3306; Database=infomanagement_db; Uid=root; Pwd=;");

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void openConnect()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnect()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
