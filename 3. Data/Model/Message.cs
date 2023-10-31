using System;
using System.Collections.Generic;

namespace _3._Data.Model;

public partial class Message : ModelBase
{
    public DateTime Time { get; set; }

    public string Content { get; set; } = null!;

    public int SendById { get; set; }

    public virtual ICollection<Chat> Chats { get; set; } = new List<Chat>();

    public virtual ICollection<Claim> Claims { get; set; } = new List<Claim>();
}
