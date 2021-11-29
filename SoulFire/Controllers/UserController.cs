using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoulFire.Entities;
using SoulFire.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class UserController : ControllerBase
    {
        private readonly IUserProvider userProvider;

        public UserController(IUserProvider userProvider)
        {
            this.userProvider = userProvider;
        }

        [HttpGet]
        [Route("{userId}/achievements")]
        public IEnumerable<UserAchievement> GetUserAchievements(Guid userId)
        {
            return userProvider.GetUserAchievements(userId);
        }

        [HttpPost]
        [Route("{userId}/achievements/{achievementId}")]
        public Task<UserAchievement> AddUserAchievement(Guid achievementId, Guid userId)
        {
            return userProvider.AddUserAchievement(achievementId, userId);
        }
    }
}
