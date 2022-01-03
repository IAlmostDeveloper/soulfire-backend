using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SoulFire.Entities
{
    public class RegisterRequest
    {
        [JsonIgnore]
        public Guid Id { get; set; }

        [MaxLength(25)]
        public string Username { get; set; }
        public string Password { get; set; }

        public string CharacterType { get; set; }

        public List<string>? AutoThoughts { get; set; }
        public List<string>? MiddleThoughts { get; set; }
        public List<string>? DeepThoughts { get; set; }
    }
}
