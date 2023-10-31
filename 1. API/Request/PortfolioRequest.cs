using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace _1._API.Request
{
    public class PortfolioRequest
    {
        [JsonIgnore]
        public int WorkerId { get; set; }
        [Required]
        [Url]
        public string ImageUrl { get; set; }
    }
}