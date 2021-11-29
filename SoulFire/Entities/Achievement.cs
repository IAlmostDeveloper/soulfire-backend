using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoulFire.Entities
{
    public class Achievement
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [MaxLength(150)]
        public string? Description { get; set; }
    }
}
