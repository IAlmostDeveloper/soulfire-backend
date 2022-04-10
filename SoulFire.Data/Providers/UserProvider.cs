using SoulFire.Core;
using SoulFire.Core.Entities;
using SoulFire.Interfaces;

namespace SoulFire.Providers
{
    public class UserProvider : IUserProvider
    {
        private readonly Context context;

        public UserProvider(Context context)
        {
            this.context = context;
        }

        public User GetUserStatistics(Guid userId)
        {
            return context.Users.FirstOrDefault(x => x.Id == userId);
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
            return context.UserAnswers.Where(x => x.SelfBeliefId == userId);
        }

        public UserAnswer GetUserAnswer(Guid answerId)
        {
            return context.UserAnswers.FirstOrDefault(x => x.Id == answerId);
        }

        public async Task<UserAnswer> AddUserAnswer(Guid userId, string question, string answer)
        {
            var userAnswer = new UserAnswer
            {
                SelfBeliefId = userId,
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
