using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
namespace Kalender
{
    class UserColums
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public string DBConnectionString = "datasource = 127.0.0.1; port=3306;username=root;password=;database=calenderdb";
        
        public MySqlConnection DatabaseConnection { get;  set; }
        public MySqlCommand CommandDatabase { get; set; }

        public void DBConnection(string sqlcommmand)
        {
            DatabaseConnection = new MySqlConnection(DBConnectionString);
            CommandDatabase = new MySqlCommand(sqlcommmand, DatabaseConnection);
            CommandDatabase.CommandTimeout = 60;
        }

    }
}
