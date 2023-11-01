using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace _1._API.Request
{
    public class AdvertisementRequest
    {
        [Required]
        [MaxLength(40)]
        public string Category { get; set; } = null!;
        [Required]
        [MaxLength(150)]
        public string Text { get; set; } = null!;
        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDay { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDay { get; set; }
        [Required]
        [Url]
        public string PictureUrl { get; set; } = null!;
        [JsonIgnore]
        public int WorkerId { get; set; }
    }
}