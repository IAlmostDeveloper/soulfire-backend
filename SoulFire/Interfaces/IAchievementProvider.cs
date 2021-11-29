using SoulFire.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoulFire.Providers
{
    public interface IAchievementProvider
    {
        Achievement GetAchievement(Guid id);
        IEnumerable<Achievement> GetAllAchievments();
        Task<Achievement> AddAchievement(Achievement achievement);
    }
}
