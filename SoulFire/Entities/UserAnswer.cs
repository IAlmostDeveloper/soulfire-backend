using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SoulFire.Entities
{
    public class UserAnswer
    {
        [JsonIgnore]
        public Guid Id { get; set; }

        public Guid SelfBeliefId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Date { get; set; }
    }
}
