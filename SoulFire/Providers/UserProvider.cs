using Microsoft.EntityFrameworkCore;
using SoulFire.Entities;
using SoulFire.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulFire.Providers
{
    public class UserProvider : IUserProvider
    {
        private readonly Context context;

        public UserProvider(Context context)
        {
            this.context = context;
        }

        public IEnumerable<UserAchievement> GetUserAchievements(Guid UserId)
        {
            var userAchievements = context.UserAchievements
                .Include(x => x.User)
                .Include(x => x.Achievement)
                .Where(ua => ua.UserId == UserId);

            //foreach (var userAchievement in userAchievements)
            //{
            //    userAchievement.Achievement = context.Achievements.FirstOrDefault(a => a.Id == userAchievement.AchievementId);
            //}

            return userAchievements;
        }

        public async Task<UserAchievement> AddUserAchievement(Guid achievementId, Guid userId)
        {
            var userAchievement = new UserAchievement
            {
                AchievementId = achievementId,
                UserId = userId,
            };
            context.UserAchievements.Add(userAchievement);
            await context.SaveChangesAsync();
            return userAchievement;
        }

        public IEnumerable<UserAnswer> GetAllAnswers()
        {
            return context.UserAnswers;
        }

        public IEnumerable<UserAnswer> GetUserAnswers(Guid userId)
        {
            return context.UserAnswers.Where(x => x.UserId == userId);
        }

        public UserAnswer GetUserAnswer(Guid answerId)
        {
            return context.UserAnswers.FirstOrDefault(x => x.Id == answerId);
        }

        public async Task<UserAnswer> AddUserAnswer(Guid userId, string question, string answer)
        {
            var userAnswer = new UserAnswer
            {
                UserId = userId,
                Question = question,
                Answer = answer
            };

            context.UserAnswers.Add(userAnswer);
            await context.SaveChangesAsync();
            return userAnswer;
        }
    }
}
