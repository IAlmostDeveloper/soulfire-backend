using SoulFire.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Providers
{
    public interface IAuthProvider
    {
        Task<LoginModel> AuthenticateUser(LoginModel login);
    }
}
