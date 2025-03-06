using Domain.Entity;
using Domain.IRepository;
using Infrastructure.Clients;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly AppDbContext _appDbContext;
        public QuestionRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task AddQuestionAsync(Question question)
        {
            await _appDbContext.Questions.AddAsync(question);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<Question>> GetQuestionsAsync()
        {
            return await _appDbContext.Questions.Include(x=>x.Survey).ThenInclude(x=>x.User).ToListAsync();
        }
    }
}
