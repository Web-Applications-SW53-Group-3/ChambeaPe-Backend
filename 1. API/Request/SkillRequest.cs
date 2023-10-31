using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace _1._API.Request
{
    public class SkillRequest
    {
        [JsonIgnore]
        public int WorkerId { get; set; }
        [Required]
        [MaxLength(40)]
        public string Content { get; set; } = null!;
    }
}