using System.ComponentModel.DataAnnotations;

namespace Api.Models.Request
{
    public record SaveSurveyRequest
    {
        public int SurveyId { get; set; } 
        public int RespondentId { get; set; }
        public List<SaveAnswerRequest> Answers { get; set; } = new();

        public class SaveAnswerRequest
        {
            public string Description { get; set; }
            public int QuestionId { get; set; } 
        }
    }
}
