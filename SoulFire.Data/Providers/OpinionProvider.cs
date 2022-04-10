using SoulFire.Core;
using SoulFire.Core.Entities;
using SoulFire.Interfaces;

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
