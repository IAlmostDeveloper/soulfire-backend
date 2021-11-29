using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SoulFire.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        
        [MaxLength(25)]
        public string Username { get; set; }
        public string Password { get; set; }

        public List<UserAchievement> Achievements { get; set; }
    }
}
