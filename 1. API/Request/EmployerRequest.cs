using System;
using System.ComponentModel.DataAnnotations;

namespace _1._API.Request
{
    public class EmployerRequest
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = null!;
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = null!;
        [Required]
        [EmailAddress]
        [MaxLength(254)]
        public string Email { get; set; } = null!;
        [Required]
        [MaxLength(30)]
        public string Password { get; set; } = null!;
        [Required]
        [MaxLength(30)]
        public string PhoneNumber { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        public DateTime Birthdate { get; set; }
        [Required]
        [MaxLength(1)]
        public string Gender { get; set; } = null!;
        [Required]
        [Url]
        [MaxLength(250)]
        public string ProfilePic { get; set; } = null!;
    }
}
