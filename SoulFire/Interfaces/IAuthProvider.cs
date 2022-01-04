using SoulFire.Entities;
using System.Threading.Tasks;

namespace SoulFire.Interfaces
{
    public interface IAuthProvider
    {
        Task<User> AuthenticateUser(AuthRequest login);
        Task<User> RegisterUser(User user);
    }
}
