namespace SoulFire.Core.Entities
{
    public class SelfBeliefProof
    {
        public Guid Id { get; set; }
        public Guid SelfBeliefId { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

    }
}
