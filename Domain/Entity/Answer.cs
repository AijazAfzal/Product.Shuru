using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        public virtual int? QuestionId { get; set; }
        [ForeignKey("QuestionId")]

        public virtual Question? Question { get; set; }

        public virtual int? SurveyResponseId { get; set; }
        [ForeignKey("SurveyResponseId")]

        public virtual SurveyResponse? SurveyResponse { get; set; }


    }
}
