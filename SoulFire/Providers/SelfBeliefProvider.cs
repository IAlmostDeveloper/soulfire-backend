using SoulFire.Entities;
using SoulFire.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Providers
{
    public class SelfBeliefProvider : ISelfBeliefProvider
    {
        private readonly Context context;

        public SelfBeliefProvider(Context context)
        {
            this.context = context;
        }

        public async Task<SelfBeliefProof> AddBeliefProof(SelfBeliefProof proof)
        {
            proof.Id = new Guid();
            context.SelfBeliefProofs.Add(proof);
            await context.SaveChangesAsync();
            return proof;

        }

        public async Task<SelfBelief> AddUserSelfBelief(SelfBelief selfBelief)
        {
            selfBelief.Id = new Guid();
            foreach (var belief in selfBelief.SelfBeliefProofs)
                belief.Id = new Guid();
            context.SelfBeliefs.Add(selfBelief);
            await context.SaveChangesAsync();
            return selfBelief;
        }

        public async Task<SelfBelief> DeleteUserSelfBelief(Guid beliefId)
        {
            SelfBelief selfBelief = context.SelfBeliefs.FirstOrDefault(x => x.Id == beliefId);
            context.SelfBeliefs.Remove(selfBelief);
            await context.SaveChangesAsync();
            return selfBelief;
        }

        public IEnumerable<SelfBeliefHelp> GetSelfBeliefsHelp()
        {
            return context.SelfBeliefHelps;
        }

        public IEnumerable<SelfBelief> GetUserSelfBeliefs(Guid userId)
        {
            var beliefs =  context.SelfBeliefs
                .Include(x => x.SelfBeliefProofs)
                .Where(x => x.UserId == userId)
                .AsNoTracking();
            return beliefs;
        }

        public async Task<SelfBelief> UpdateUserSelfBelief(Guid beliefId, SelfBelief selfBelief)
        {
            var sBelief = context.SelfBeliefs.FirstOrDefault(x => x.Id == beliefId);
            sBelief.OldSelfBelief = selfBelief.OldSelfBelief;
            sBelief.OldSelfBeliefRule = selfBelief.OldSelfBeliefRule;
            sBelief.NewSelfBelief = selfBelief.NewSelfBelief;
            sBelief.NewSelfBeliefRule = selfBelief.NewSelfBeliefRule;
            if (sBelief.SelfBeliefProofs != null && sBelief.SelfBeliefProofs.Count != selfBelief.SelfBeliefProofs.Count)
            {
                sBelief.SelfBeliefProofs.Clear();
                foreach (var proof in selfBelief.SelfBeliefProofs)
                {
                    var prf = context.SelfBeliefProofs.FirstOrDefault(x => x.Id == proof.Id);
                    if (prf != null)
                    {
                        prf.Title = proof.Title;
                        prf.Content = proof.Content;
                        prf.Type = proof.Type;
                    }
                    else
                    {
                        proof.Id = new Guid();
                        context.SelfBeliefProofs.Add(proof);
                    }
                    //context.Entry(proof).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                    //sBelief.Proofs.Add(proof);
                    //context.SelfBeliefProofs.Add(proof);
                }
            }
            //} else
            //    sBelief.Proofs = selfBelief.Proofs;
            await context.SaveChangesAsync();
            return selfBelief;
        }
    }
}
