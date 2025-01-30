using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Principle_In_CSharp.SRP
{
    public class AuthManager
    {
        public void Login()
        {
            // Login the user
        }
        public void Logout()
        {
            // Logout the User
        }

        public Boolean IsCurrentUserAuthenticated()
        {
            //Wheter the Current User is authenticated or not
        }

        public Employee GetCurrentLogedInUser()
        {
            //Get The Current Logged in User details
        }
    }
}