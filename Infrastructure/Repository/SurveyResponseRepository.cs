using Domain.Entity;
using Domain.IRepository;
using Infrastructure.Clients;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class SurveyResponseRepository : ISurveyResponseRepository
    {
        private readonly AppDbContext _appDbContext;
        public SurveyResponseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<SurveyResponse>> GetSurveyResponsesAsync()
        {

           return await _appDbContext.SurveyResponses
                                           .Include(x=>x.Survey)
                                           .Include(x => x.Respondent) 
                                           .Include(x => x.Answers)
                                           .ThenInclude(x => x.Question)  
                                           .ToListAsync();
        }

        public async Task SaveSurveyResponseAsync(SurveyResponse surveyResponse)
        {
            await _appDbContext.SurveyResponses.AddAsync(surveyResponse);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
