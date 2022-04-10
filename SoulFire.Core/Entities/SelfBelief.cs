using System.ComponentModel.DataAnnotations.Schema;

namespace SoulFire.Core.Entities
{
    public class SelfBelief
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string OldSelfBeliefRule { get; set; }
        public string OldSelfBelief { get; set; }
        public string NewSelfBeliefRule { get; set; }
        public string NewSelfBelief { get; set; }

        [ForeignKey("SelfBeliefId")]
        public virtual List<SelfBeliefProof> SelfBeliefProofs { get; set; }

        [ForeignKey("SelfBeliefId")]
        public virtual List<UserAnswer> UserAnswers { get; set; }

    }
}
