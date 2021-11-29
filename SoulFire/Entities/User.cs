﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Domain.Entities
{ 
    public class User
    {
        public Guid Id { get; set; }
        
        [MaxLength(25)]
        public string Username { get; set; }
        public string Password { get; set; }

        public List<Achievement> Achievements { get; set; }
    }
}
