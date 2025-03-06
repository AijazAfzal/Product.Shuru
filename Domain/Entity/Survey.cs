using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entity
{
    public class Survey
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual int? UserId { get; set; }  //user who created survey

        public virtual User? User { get; set; }
        [JsonIgnore]
        public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}
