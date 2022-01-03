using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SoulFire.Entities
{
    public class UserAutoThought
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        
        public string Content { get; set; }

        [JsonIgnore]
        public virtual User User { get; set; }
    }
}
