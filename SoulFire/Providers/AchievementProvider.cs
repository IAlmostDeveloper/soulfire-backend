using SoulFire.Entities;
using SoulFire.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Providers
{
    public class AchievementProvider : IAchievementProvider
    {
        private readonly Context context;

        public AchievementProvider(Context context)
        {
            this.context = context;
        }

        public Achievement GetAchievement(Guid id) => context.Achievements.FirstOrDefault(a => a.Id == id);

        public IEnumerable<Achievement> GetAllAchievments() => context.Achievements;

        public async Task<Achievement> AddAchievement(Achievement achievement)
        {
            context.Achievements.Add(achievement);
            await context.SaveChangesAsync();
            return achievement;
        }
    }
}
