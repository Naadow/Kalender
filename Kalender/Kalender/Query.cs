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
    class Query
    {
        UserColums UserColums = new UserColums();

       public void insertinto(string userName, string password, string email)
        {
            string insert_command = $"INSERT INTO tbl_users(Username, Password, Email) VALUES ('{userName}','{(password)}','{email}'); ";

            UserColums.DBConnection(insert_command);
            MySqlConnection databaseConnection = UserColums.DatabaseConnection;
            MySqlCommand commandDatabase = UserColums.CommandDatabase;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
            }

            catch (Exception)
            {

                throw;
            }
        }
        


    }
}
