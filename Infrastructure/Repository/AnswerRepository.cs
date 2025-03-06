using Domain.Entity;
using Domain.IRepository;
using Infrastructure.Clients;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly AppDbContext _appDbContext;
        public AnswerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Answer>> GetAnswersAsync()
        {
            return await _appDbContext.Answers.Include(x=>x.Question).ToListAsync();
        }

        public async Task PostAnswerAsync(Answer answer)
        {
            await _appDbContext.Answers.AddAsync(answer);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
