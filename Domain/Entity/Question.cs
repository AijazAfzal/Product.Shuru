using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        public virtual int? SurveyId { get; set; }  // Foreign key to Survey
        [ForeignKey("SurveyId")]
        public virtual Survey? Survey { get; set; }
    }
}
