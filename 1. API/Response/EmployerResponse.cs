namespace _1._API.Response
{
    public class EmployerResponse
    {
        public int EmployerId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; } = null!;
        public string UserRole { get; set; } = null!;
        public bool HasPremium { get; }
        public string ProfilePic { get; set; } = null!;
    }
}
