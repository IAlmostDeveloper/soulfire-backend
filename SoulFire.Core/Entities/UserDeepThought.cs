using System.Text.Json.Serialization;

namespace SoulFire.Core.Entities
{
    public class UserDeepThought
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Content { get; set; }

        [JsonIgnore]
        public virtual User User { get; set; }
    }
}
