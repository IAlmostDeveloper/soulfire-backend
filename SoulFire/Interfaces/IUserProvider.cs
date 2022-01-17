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
        Task<UserAchievement> AddUserAchievement(UserAchievement userAchievement);
        IEnumerable<UserAnswer> GetAllAnswers();
        User GetUserStatistics(Guid userId);
        IEnumerable<UserAnswer> GetUserAnswers(Guid userId);
        UserAnswer GetUserAnswer(Guid answerId);
        Task<UserAnswer> AddUserAnswer(Guid userId, string question, string answer);
        Task<UserAchievement> UpdateUserAchievement(Guid achievementId, UserAchievement userAchievement);
        Task<UserAchievement> DeleteUserAchievement(Guid achievementId);
    }
}
