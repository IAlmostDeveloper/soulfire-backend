using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SoulFire.Core.Entities
{
    public class User
    {
        [JsonIgnore]
        public Guid Id { get; set; }

        [MaxLength(25)]
        public string Username { get; set; }
        public string Password { get; set; }

        public string CharacterType { get; set; }

        public virtual List<UserAchievement>? Achievements { get; set; }
        public virtual List<UserAutoThought>? AutoThoughts { get; set; }
        public virtual List<UserMiddleThought>? MiddleThoughts { get; set; }
        public virtual List<UserDeepThought>? DeepThoughts { get; set; }
    }
}
