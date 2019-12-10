using System.Net.Http.Headers;

namespace Kalender
{
    public class ErrorMessanges
    {
        public bool allEntered(string username, string password, string reenteredpassword, string email)
        {
            if (((string.IsNullOrWhiteSpace((username)) || string.IsNullOrWhiteSpace((password)) || string.IsNullOrWhiteSpace((reenteredpassword)) || string.IsNullOrWhiteSpace((email)))) ||  string.IsNullOrWhiteSpace((username)) && string.IsNullOrWhiteSpace((password)) && string.IsNullOrWhiteSpace((reenteredpassword)) && string.IsNullOrWhiteSpace((email)) )
            {
                return false;
            }
            return true;
        }

    }
}