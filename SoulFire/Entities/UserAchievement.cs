using System;

namespace SoulFire.Entities
{
    public class UserAchievement
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid AchievementId { get; set; }
        public DateTime Date { get; set; }

        public virtual User User { get; set; }
        public virtual Achievement Achievement { get; set; }
    }
}
