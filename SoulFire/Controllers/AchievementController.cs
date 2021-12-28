using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SoulFire.Entities;
using SoulFire.Interfaces;
using System;
using System.Collections.Generic;
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
        public ActionResult GetAllAchievements() => Ok(new { status_code = 200, achievements = achievementProvider.GetAllAchievments() });

        [HttpPost]
        public async Task<Achievement> AddAchievement([FromBody] Achievement achievement) => await achievementProvider.AddAchievement(achievement);
    }
}
