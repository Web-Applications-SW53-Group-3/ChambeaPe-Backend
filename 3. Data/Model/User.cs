using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace _3._Data.Model;

public partial class User : ModelBase
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string PhoneNumber { get; set; }= null!;
    public string Description { get; set; } = null!;

    public DateTime Birthdate { get; set; }

    public string Gender { get; set; } = null!;
    public string UserRole { get; set; } = null!;

    public bool HasPremium { get; set; }

    public string ProfilePic { get; set; } = null!;
    public virtual ICollection<Employer> Employers { get; set; } = new List<Employer>();
    public virtual ICollection<Suscription> Suscriptions { get; set; } = new List<Suscription>();
    public virtual ICollection<UserNotification> UserNotifications { get; set; } = new List<UserNotification>();
    public virtual ICollection<Worker> Workers { get; set; } = new List<Worker>();
}
