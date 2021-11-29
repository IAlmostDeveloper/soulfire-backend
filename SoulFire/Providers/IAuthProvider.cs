using SoulFire.Entities;
using System.Threading.Tasks;

namespace SoulFire.Providers
{
    public interface IAuthProvider
    {
        Task<User> AuthenticateUser(User login);
    }
}
