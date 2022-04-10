using System.Text.Json.Serialization;

namespace SoulFire.Core.Entities
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
