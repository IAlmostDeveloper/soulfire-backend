using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoulFire.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AchievementController : ControllerBase
    {
        private readonly Context context;

        public AchievementController(Context context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("{id}")]
        public Achievement GetAchievement(Guid id) => context.Achievements.FirstOrDefault(a => a.Id == id);

        [HttpGet]
        public IEnumerable<Achievement> GetAllAchievements()
        {
            return context.Achievements;
        }

        [HttpPost]
        public async Task<Achievement> AddAchievement([FromBody] Achievement achievement)
        {
            context.Add(achievement);
            await context.SaveChangesAsync();
            return achievement;
        }
    }
}
