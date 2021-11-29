using Microsoft.EntityFrameworkCore;
using SoulFire.Domain.Entities;

namespace SoulFire
{
    public class Context : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Achievement> Achievements { get; set; }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
            
        }
    }
}
