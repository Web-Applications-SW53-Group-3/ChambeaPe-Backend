using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace _1._API.Request
{
    public class CertificateRequest
    {
        [Required]
        [MaxLength(60)]
        public string Name { get; set; } = null!;
        [Required]
        [Url]
        public string ImgUrl { get; set; } = null!;
        [Required]
        [MaxLength(60)]
        public string InstitutionName { get; set; } = null!;
        [Required]
        [MaxLength(40)]
        public string TeacherName { get; set; } = null!;
        [Required]
        [DataType(DataType.Date)]
        public DateTime IssueDate { get; set; }
        [Required]
        [MaxLength(60)]
        public string CertificateName { get; set; } = null!;
        [JsonIgnore]
        public int WorkerId { get; set; }
    }
}