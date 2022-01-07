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
                .Where(ua => ua.UserId == UserId).OrderByDescending(x => x.UpdatedDate);

            return userAchievements;
        }

        public async Task<UserAchievement> AddUserAchievement(UserAchievement userAchievement)
        {
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

        public async  Task<UserAchievement> UpdateUserAchievement(Guid achievementId, UserAchievement userAchievement)
        {
            UserAchievement ua = context.UserAchievements.FirstOrDefault(x => x.Id == achievementId);
            ua.Title = userAchievement.Title;
            ua.Content = userAchievement.Content;
            ua.Description = userAchievement.Description;

            await context.SaveChangesAsync();
            return ua;
        }

        public async Task<UserAchievement> DeleteUserAchievement(Guid achievementId)
        {
            UserAchievement ua = context.UserAchievements.FirstOrDefault(x => x.Id == achievementId);
            context.UserAchievements.Remove(ua);
            await context.SaveChangesAsync();

            return ua;
        }
    }
}
