using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Entities
{
    public class SelfBeliefProof
    {
        public Guid Id { get; set; }
        public Guid SelfBeliefId { get; set; }
        public string Type { get; set; } 
        public string Title { get; set; }
        public string Content { get; set; }

    }
}
