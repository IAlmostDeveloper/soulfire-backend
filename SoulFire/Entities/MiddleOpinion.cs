using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SoulFire.Entities
{
    public class MiddleOpinion
    {
        [JsonIgnore]
        public Guid Id { get; set; }

        public string Content { get; set; }
    }
}
