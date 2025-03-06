using Domain.Entity;

namespace Domain.IRepository
{
    public interface ISurveyRepository
    {
        Task CreateSurveyAsync(Survey survey);

        Task<List<Survey>> GetSurveysAsync();
    }
}
