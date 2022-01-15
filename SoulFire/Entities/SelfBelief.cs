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
        public string Title { get; set; }
        public string Content { get; set; }

        [ForeignKey("SelfBeliefId")]
        public virtual List<SelfBeliefProof> SelfBeliefProofs { get; set; }

        [ForeignKey("SelfBeliefId")]
        public virtual List<UserAnswer> UserAnswers { get; set; }

    }
}
