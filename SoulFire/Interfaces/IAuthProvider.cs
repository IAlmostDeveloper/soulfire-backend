using SoulFire.Entities;
using System.Threading.Tasks;

namespace SoulFire.Interfaces
{
    public interface IAuthProvider
    {
        Task<User> AuthenticateUser(User login);
        Task<User> RegisterUser(User user);
    }
}
