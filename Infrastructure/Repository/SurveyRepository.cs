using Domain.Entity;
using Domain.IRepository;
using Infrastructure.Clients;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class SurveyRepository : ISurveyRepository
    {
        private readonly AppDbContext _appDbContext;
        public SurveyRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;   
        }

        public async Task CreateSurveyAsync(Survey survey)
        {
            await _appDbContext.Surveys.AddAsync(survey);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<Survey>> GetSurveysAsync()
        {
            return await _appDbContext.Surveys.Include(x=>x.Questions).Include(x=>x.User).ToListAsync();
        }
    }
}
