using System.ComponentModel.DataAnnotations;

namespace Api.Models.Request
{
    public record CreateSurveyRequest
    {
        [Required]
        public string Name { get; set; }

        public int UserId { get; set; }
    }
}
