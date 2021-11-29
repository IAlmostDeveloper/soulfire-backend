using SoulFire.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Providers
{
    public class AuthProvider : IAuthProvider
    {
        async Task<LoginModel> IAuthProvider.AuthenticateUser(LoginModel login)
        {
            LoginModel user = null;

            //Validate the User Credentials      
            //Demo Purpose, I have Passed HardCoded User Information      
            if (login.UserName == "Jay")
            {
                user = new LoginModel { UserName = "Jay", Password = "123456" };
            }
            return user;
        }
    }
}
