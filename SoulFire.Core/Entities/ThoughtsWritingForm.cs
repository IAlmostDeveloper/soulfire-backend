using System.Text.Json.Serialization;

namespace SoulFire.Core.Entities
{
    public class ThoughtsWritingForm
    {
        [JsonIgnore]
        public Guid Id { get; set; }

        public string Content { get; set; }
    }
}
