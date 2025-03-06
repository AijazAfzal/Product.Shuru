using Domain.Entity;

namespace Domain.IRepository
{
    public interface IQuestionRepository
    {
        Task<List<Question>> GetQuestionsAsync();
        Task AddQuestionAsync(Question question); 
    }
}
