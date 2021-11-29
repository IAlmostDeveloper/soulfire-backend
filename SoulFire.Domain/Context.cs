using Microsoft.EntityFrameworkCore;
using SoulFire.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoulFire.Domain
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Achievement> Achievements { get; set; }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
            
        }
    }
}
