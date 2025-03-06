using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Respondent
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
