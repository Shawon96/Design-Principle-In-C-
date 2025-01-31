using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Principle_In_CSharp.OCP
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
            return true;
        }

        public Employee GetCurrentLogedInUser()
        {
            return new Employee();
        }
    }
}