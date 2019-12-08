using System.Net.Http.Headers;

namespace Kalender
{
    public class ErrorMessanges
    {
        public bool allEntered(string username, string password, string reenteredpassword, string email)
        {
            if (username == null || password==null || reenteredpassword==null || email == null )
            {
                return false;
            }
            return true;
        }

    }
}