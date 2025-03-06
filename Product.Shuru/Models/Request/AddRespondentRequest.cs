using System.ComponentModel.DataAnnotations;

namespace Api.Models.Request
{
    public record AddRespondentRequest
    {
        [Required]
        public string Name { get; set; }
    }
}
