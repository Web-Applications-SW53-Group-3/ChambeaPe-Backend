using System;
using System.Collections.Generic;

namespace _3._Data.Model;

public partial class Notification : ModelBase
{
    public string Content { get; set; } = null!;

    public DateTime Date { get; set; }

    public virtual ICollection<UserNotification> UserNotifications { get; set; } = new List<UserNotification>();
}
