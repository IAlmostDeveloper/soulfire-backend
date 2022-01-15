using SoulFire.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Interfaces
{
    public interface ISelfBeliefProvider
    {
        IEnumerable<SelfBelief> GetUserSelfBeliefs(Guid userId);
        Task<SelfBelief> AddUserSelfBelief(SelfBelief selfBelief);
        Task<SelfBelief> UpdateUserSelfBelief(Guid beliefId, SelfBelief selfBelief);
        Task<SelfBelief> DeleteUserSelfBelief(Guid beliefId);
        Task<SelfBeliefProof> AddBeliefProof(SelfBeliefProof proof);
    }
}
