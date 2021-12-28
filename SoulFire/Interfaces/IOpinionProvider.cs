using SoulFire.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Interfaces
{
    interface IOpinionProvider
    {
        public IEnumerable<ThoughtsWritingForm> GetThoughtsWritingForms();

        public IEnumerable<ThoughtsSimpleForm> GetThoughtsSimpleForms();

        public IEnumerable<MiddleOpinion> GetMiddleOpinions();

        public IEnumerable<DeepOpinion> GetDeepOpinions();
    }
}
