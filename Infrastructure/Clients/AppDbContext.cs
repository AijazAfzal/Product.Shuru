using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Clients
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {        
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Answer> Answers { get; set; }

        public DbSet<Survey> Surveys { get; set; }  

        public DbSet<Respondent> Respondents { get; set; } 

        public DbSet<SurveyResponse> SurveyResponses { get; set; } 


    }
}
