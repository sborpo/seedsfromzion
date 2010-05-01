using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace seedsfromzion.Managers
{
    enum UserType { ADMIN, ORDINARY };

    public static class SystemManager
    {
        private static UserType logedIn;

        UserType LogedIn
        {
            get { return logedIn; }
            set { logedIn = value; }
        }

        private static string hashPassword(string userPass)
        {
            return userPass;
        }
    }
}
