using System;
using System.Collections.Generic;

namespace _3._Data.Model;

public partial class UserNotification : ModelBase
{
    public int UserId { get; set; }

    public int NotificationsId { get; set; }

    public bool Read { get; set; }

    public virtual Notification Notifications { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
