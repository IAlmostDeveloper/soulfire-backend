using System;
using System.ComponentModel.DataAnnotations;

namespace SoulFire.Core.Entities
{
    public class Achievement
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [MaxLength(150)]
        public string? Description { get; set; }
    }
}
