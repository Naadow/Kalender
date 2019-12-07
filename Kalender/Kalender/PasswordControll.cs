using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalender
{
    class PasswordControll
    {
        public string Password { get; set; }
        public string Hashedpassword { get; set; }



        public bool samePassword(string password, string reenteredpassword)
        {
            if (password == reenteredpassword)
            {
                return true;
            }

            else
                return false;
        }

        public string HashPassword(string password)
        {
            password = BCrypt.Net.BCrypt.HashPassword(password);

            return password;
        }

    }
}
