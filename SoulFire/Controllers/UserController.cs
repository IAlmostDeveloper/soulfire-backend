using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoulFire.Core.Entities;
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
        [Route("achievements/{userId}")]
        public ActionResult GetUserAchievements(Guid userId)
        {
            return Ok(new { status = 200, userAchievements = userProvider.GetUserAchievements(userId) });
        }

        [HttpGet]
        [Route("statistics/{userId}")]
        public ActionResult GetUserStatistics(Guid userId)
        {
            return Ok(new { status = 200, result = userProvider.GetUserStatistics(userId) });
        }

        [HttpPost]
        [Route("achievements")]
        public ActionResult AddUserAchievement([FromBody] UserAchievement userAchievement)
        {
            userAchievement.Id = new Guid();
            return Ok(new { status = 200, result = userProvider.AddUserAchievement(userAchievement).Result});
        }

        [HttpPatch]
        [Route("achievements/{achievementId}")]
        public ActionResult UpdateUserAchievement(Guid achievementId, [FromBody] UserAchievement userAchievement)
        {
            return Ok(new { status = 200, result = userProvider.UpdateUserAchievement(achievementId, userAchievement).Result });
        }

        [HttpDelete]
        [Route("achievements/{achievementId}")]
        public ActionResult DeleteUserAchievement(Guid achievementId)
        {
            return Ok(new { status = 200, result = userProvider.DeleteUserAchievement(achievementId).Result});
        }


        [HttpGet]
        [Route("{userId}/answers")]
        public ActionResult GetUserAnswers(Guid userId)
        {
            return Ok(new { status = 200, userAnswers = userProvider.GetUserAnswers(userId) });
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
