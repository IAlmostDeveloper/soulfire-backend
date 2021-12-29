using SoulFire.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Interfaces
{
    public interface IUserProvider
    {
        IEnumerable<UserAchievement> GetUserAchievements(Guid UserId);
        Task<UserAchievement> AddUserAchievement(Guid achievementId, Guid userId);
        IEnumerable<UserAnswer> GetAllAnswers();
        IEnumerable<UserAnswer> GetUserAnswers(Guid userId);
        UserAnswer GetUserAnswer(Guid answerId);
        Task<UserAnswer> AddUserAnswer(Guid userId, string question, string answer);
    }
}
