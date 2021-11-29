using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SoulFire.Entities;
using SoulFire.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AchievementController : ControllerBase
    {
        private readonly IAchievementProvider achievementProvider;

        public AchievementController(IAchievementProvider achievementProvider)
        {
            this.achievementProvider = achievementProvider;
        }

        [HttpGet]
        [Route("{id}")]
        public Achievement GetAchievement(Guid id) => achievementProvider.GetAchievement(id);

        [HttpGet]
        public IEnumerable<Achievement> GetAllAchievements() => achievementProvider.GetAllAchievments();

        [HttpPost]
        public async Task<Achievement> AddAchievement([FromBody] Achievement achievement) => await achievementProvider.AddAchievement(achievement);
    }
}
