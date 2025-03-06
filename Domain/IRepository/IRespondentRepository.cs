using Domain.Entity;

namespace Domain.IRepository
{
    public interface IRespondentRepository
    {
        Task<List<Respondent>> GetRespondentsAsync();
        Task AddRespondentAsync(Respondent respondent);
    }
}
