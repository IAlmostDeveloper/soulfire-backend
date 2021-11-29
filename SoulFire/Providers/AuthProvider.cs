using SoulFire.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Providers
{
    public class AuthProvider : IAuthProvider
    {
        async Task<User> IAuthProvider.AuthenticateUser(User login)
        {
            User user = null;

            //Validate the User Credentials      
            //Demo Purpose, I have Passed HardCoded User Information      
            if (login.Username == "Jay")
            {
                user = new User { Username = "Jay", Password = "123456" };
            }
            return user;
        }
    }
}
