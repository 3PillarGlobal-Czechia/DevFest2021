using BeerQuiz.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace BeerQuiz.Infrastructure
{
    public class BeerQuizDbContext : DbContext
    {
        public DbSet<QuizItem> QuizItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("BeeerQuizDatabase");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuizItem>(builder =>
            {
                builder
                    .Property(i => i.Options)
                    .HasConversion(o => string.Join(",", o), o => o.Split(",", StringSplitOptions.RemoveEmptyEntries));
            });


            // NOTE (Peter): This JSON seeding is only done for demonstration purposes.
            //               In the real world we'd just have a database ready.
            var questions = JsonConvert.DeserializeObject<IEnumerable<QuizItem>>(File.ReadAllText("questions.json"));

            if (questions is null)
                throw new Exception("Couldn't get questions from the JSON file.");

            modelBuilder.Entity<QuizItem>().HasData(questions);
        }
    }
}
