using System;
using System.Security.AccessControl;
using MySql.Data.MySqlClient;


namespace Kalender
{
    public class SignUp
    {
        public string Email { get; set; }
        public string Password { get; set; }

        
        private readonly Query _queryClass = new Query();
        private readonly UserColums _userClass = new UserColums();
        

        public bool controllData(string username, string password)
        {
            string select_command = $"select Username,Password from tbl_users where Username='{username}'";
            _userClass.DBConnection(select_command);
            MySqlConnection databaseConnection = _userClass.DatabaseConnection;
            MySqlCommand commandDatabase = _userClass.CommandDatabase;

            try
            {
                _userClass.DatabaseConnection.Open();
                MySqlDataReader mySqlDataReader = _userClass.CommandDatabase.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    var usernameresult = mySqlDataReader[0].ToString();
                    var passwordresult = mySqlDataReader[1].ToString();
                    bool verifyPassword = BCrypt.Net.BCrypt.Verify(password, passwordresult);

                    if (usernameresult == username && verifyPassword == true)
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