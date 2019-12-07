using System;
using MySql.Data.MySqlClient;

namespace Kalender
{
    public class EmailContorll
    {
        public string Email { get; set; }


        private UserColums _userClass  = new UserColums();

        public bool conrtollemail(string email)
        {
            string select_command = $"select Email from tbl_users Where Email='{email}'";
            _userClass.DBConnection(select_command);
            MySqlConnection databaseConnection = _userClass.DatabaseConnection;
            MySqlCommand commandDatabase = _userClass.CommandDatabase;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    var readresult = myReader[0].ToString();
                    if (readresult == email)
                    {
                        return true;
                    }

                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

            return false;
        }
        
    }
}