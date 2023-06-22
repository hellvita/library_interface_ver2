using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace library_interface_ver2
{
    class DataBase
    {
        // create connection to database 'library'
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;uid=LocalUser1;pwd=User1;database=library");
        // create method for opening connection
        public void openConenection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) { connection.Open(); }
        }
        // create method for closing connection
        public void closeConenection()
        {
            if (connection.State == System.Data.ConnectionState.Open) { connection.Close(); }
        }
        // create method for getting connection
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
