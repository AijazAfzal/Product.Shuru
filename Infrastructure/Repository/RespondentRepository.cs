using Domain.Entity;
using Domain.IRepository;
using Infrastructure.Clients;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class RespondentRepository : IRespondentRepository
    {
        private readonly AppDbContext _appDbContext;
        public RespondentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddRespondentAsync(Respondent respondent)
        {
            await _appDbContext.Respondents.AddAsync(respondent);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<Respondent>> GetRespondentsAsync()
        {
            return await _appDbContext.Respondents.ToListAsync();
        }
    }
}
