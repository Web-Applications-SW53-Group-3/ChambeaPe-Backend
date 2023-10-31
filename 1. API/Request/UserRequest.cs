using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace _1._API.Request
{
    public class UserRequest
    {
        [Required]
        public string FirstName { get; set; } = null!;
        [Required]
        public string LastName { get; set; } = null!;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
        [Required]
        public string PhoneNumber { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        public DateTime Birthdate { get; set; }
        [Required]
        public string Gender { get; set; } = null!;
        [Required]
        public string UserRole { get; set; } = null!;
        [Required]
        [Url]
        public string ProfilePic { get; set; } = null!;
    }
}
