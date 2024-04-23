using Microsoft.EntityFrameworkCore;

namespace languageLearning.Models
{
    public class EFLanguageLearningContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Audio> Audios { get; set; }

        public EFLanguageLearningContext(DbContextOptions<EFLanguageLearningContext> options) : base(options)
        {

        }

    }
}
