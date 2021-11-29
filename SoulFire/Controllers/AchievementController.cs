using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoulFire.Domain.Entities;
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
        public IEnumerable<Achievement> GetAllAchievements()
        {
            return this.context.Achievements;
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
