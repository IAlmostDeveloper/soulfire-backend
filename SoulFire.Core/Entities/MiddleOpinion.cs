using System.Text.Json.Serialization;

namespace SoulFire.Core.Entities
{
    public class MiddleOpinion
    {
        [JsonIgnore]
        public Guid Id { get; set; }

        public string Content { get; set; }
    }
}
