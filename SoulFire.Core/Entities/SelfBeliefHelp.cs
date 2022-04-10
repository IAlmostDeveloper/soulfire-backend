namespace SoulFire.Core.Entities
{
    public class SelfBeliefHelp
    {
        public Guid Id { get; set; }
        public int Type { get; set; }
        public string Content { get; set; }
        public bool CanSkip { get; set; }
    }
}
