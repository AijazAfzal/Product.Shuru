using Domain.Entity;

namespace Domain.IRepository
{
    public interface IAnswerRepository
    {
        Task<List<Answer>> GetAnswersAsync();
        Task PostAnswerAsync(Answer answer);
    }
}
