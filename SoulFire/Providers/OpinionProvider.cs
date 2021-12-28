using SoulFire.Entities;
using SoulFire.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Providers
{
    public class OpinionProvider : IOpinionProvider
    {
        private readonly Context context;

        public OpinionProvider(Context context)
        {
            this.context = context;
        }

        public IEnumerable<ThoughtsWritingForm> GetThoughtsWritingForms()
        {
            return context.ThoughtsWritingForms;
        }

        public IEnumerable<ThoughtsSimpleForm> GetThoughtsSimpleForms()
        {
            return context.ThoughtsSimpleForms;
        }

        public IEnumerable<MiddleOpinion> GetMiddleOpinions()
        {
            return context.MiddleOpinions;
        }

        public IEnumerable<DeepOpinion> GetDeepOpinions()
        {
            return context.DeepOpinions;
        }
    }
}
