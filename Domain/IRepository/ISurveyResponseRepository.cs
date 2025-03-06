using Domain.Entity;

namespace Domain.IRepository
{
    public interface ISurveyResponseRepository
    {
        Task<List<SurveyResponse>> GetSurveyResponsesAsync();

        Task SaveSurveyResponseAsync(SurveyResponse surveyResponse);
    }
}
