using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entity
{
    public class SurveyResponse
    {
        [Key]
        public int Id { get; set; }

        public virtual int? SurveyId { get; set; } 
        [ForeignKey("SurveyId")]
        public virtual Survey? Survey { get; set; }

        public virtual int? RespondentId { get; set; }
        [ForeignKey("RespondentId")]

        public virtual Respondent? Respondent { get; set; }
        [JsonIgnore]

        public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();
    }
}
