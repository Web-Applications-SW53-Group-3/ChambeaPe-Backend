using System.ComponentModel.DataAnnotations;

namespace _1._API.Request
{
    public class PostRequest
    {
        [Required]
        [MaxLength(40)]
        public string Title { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string Subtitle { get; set; } = null!;

        [Required]
        [MaxLength(255)]
        [Url]
        public string ImgUrl { get; set; } = null!;
    }
}
