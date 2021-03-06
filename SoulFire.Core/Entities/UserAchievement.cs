namespace SoulFire.Core.Entities
{
    public class UserAchievement
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string UpdatedDate { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
    }
}
