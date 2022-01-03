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
        public ActionResult GetUserAchievements(Guid userId)
        {
            return Ok(new { status = 200, userAchievements = userProvider.GetUserAchievements(userId) });
        }

        [HttpPost]
        [Route("{userId}/achievements/{achievementId}")]
        public Task<UserAchievement> AddUserAchievement(Guid achievementId, Guid userId)
        {
            return userProvider.AddUserAchievement(achievementId, userId);
        }

        [HttpGet]
        [Route("{userId}/answers")]
        public ActionResult GetUserAnswers(Guid userId)
        {
            return Ok(new { status = 200, userAnswers = userProvider.GetUserAnswers(userId)});
        }

        [HttpGet]
        [Route("{userId}/answers/{answerId}")]
        public ActionResult GetUserAnswer(Guid answerId)
        {
            return Ok(new { status = 200, userAnswer = userProvider.GetUserAnswer(answerId) });
        }

        [HttpPost]
        [Route("{userId}/answers")]
        public Task<UserAnswer> AddUserAnswer(Guid userId)

        {
            return userProvider.AddUserAnswer(userId, "", "");
        }
    }
}
