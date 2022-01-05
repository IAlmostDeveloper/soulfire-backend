﻿using Microsoft.EntityFrameworkCore;
using SoulFire.Entities;

namespace SoulFire
{
    public class Context : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Achievement> Achievements { get; set; }
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



        public Context(DbContextOptions<Context> options)
            : base(options)
        {

        }
    }
}
