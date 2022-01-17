using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SoulFire.Entities
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
