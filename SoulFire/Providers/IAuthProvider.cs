using SoulFire.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Providers
{
    public interface IAuthProvider
    {
        Task<User> AuthenticateUser(User login);
    }
}
