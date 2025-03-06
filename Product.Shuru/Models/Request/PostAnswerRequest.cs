using Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models.Request
{
    public record PostAnswerRequest
    {
        public string Description { get; set; }

        public  int QuestionId { get; set; }

        public int SurveyResponseId { get; set; }
    }
}
