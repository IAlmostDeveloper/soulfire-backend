using System.Text.Json.Serialization;

namespace SoulFire.Core.Entities
{
    public class ThoughtsSimpleForm
    {
        [JsonIgnore]
        public Guid Id { get; set; }

        public string Content { get; set; }
    }
}
