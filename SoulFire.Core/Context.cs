using Microsoft.EntityFrameworkCore;
using SoulFire.Core.Entities;

namespace SoulFire.Core
{
    public class Context : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAchievement> UserAchievements { get; set; }
        public virtual DbSet<ThoughtsWritingForm> ThoughtsWritingForms { get; set; }
        public virtual DbSet<ThoughtsSimpleForm> ThoughtsSimpleForms { get; set; }
        public virtual DbSet<MiddleOpinion> MiddleOpinions { get; set; }
        public virtual DbSet<DeepOpinion> DeepOpinions { get; set; }
        public virtual DbSet<UserAnswer> UserAnswers { get; set; }
        public virtual DbSet<UserAutoThought> UserAutoThoughts { get; set; }
        public virtual DbSet<UserMiddleThought> UserMiddleThoughts { get; set; }
        public virtual DbSet<UserDeepThought> UserDeepThoughts { get; set; }
        public virtual DbSet<DiaryNote> DiaryNotes { get; set; }
        public virtual DbSet<Preset> Presets { get; set; }
        public virtual DbSet<SelfBelief> SelfBeliefs { get; set; }
        public virtual DbSet<SelfBeliefProof> SelfBeliefProofs { get; set; }
        public virtual DbSet<DiaryNoteHelp> DiaryNoteHelps { get; set; }
        public virtual DbSet<SelfBeliefHelp> SelfBeliefHelps { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<SelfBelief>()
                .HasMany(x => x.SelfBeliefProofs)
                .WithOne()
                .HasForeignKey(x => x.SelfBeliefId);
            modelBuilder
                .Entity<SelfBelief>()
                .HasMany(x => x.UserAnswers)
                .WithOne()
                .HasForeignKey(x => x.SelfBeliefId);

        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {

        }
    }
}