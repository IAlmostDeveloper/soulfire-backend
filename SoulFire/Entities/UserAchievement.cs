using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SoulFire.Entities
{
    public class UserAchievement
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid AchievementId { get; set; }
        public DateTime Date { get; set; }

        [JsonIgnore]
        public virtual User User { get; set; }

        [ForeignKey("AchievementId")]
        public virtual Achievement Achievement { get; set; }
    }
}
