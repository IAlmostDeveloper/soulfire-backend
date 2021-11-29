using SoulFire.Entities;
using SoulFire.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Providers
{
    public class AuthProvider : IAuthProvider
    {
        private readonly Context context;

        public AuthProvider(Context context)
        {
            this.context = context;
        }

        public async Task<User> AuthenticateUser(User user)
        {
            var userCheck = context.Users.FirstOrDefault(u => u.Username == user.Username);
            if (userCheck == null)
                return null;
            return userCheck;
        }

        public async Task<User> RegisterUser(User user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();
            return user;
        }
    }
}
