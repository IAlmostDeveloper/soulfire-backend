using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Core.Entities
{
    public class Preset
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string UpdatedDate { get; set; }
    }
}
