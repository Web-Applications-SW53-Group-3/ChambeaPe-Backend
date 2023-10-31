using System;
using System.Collections.Generic;

namespace _3._Data.Model;

public partial class Contract : ModelBase
{
    public int WorkerId { get; set; }

    public string Content { get; set; } = null!;

    public DateTime StartDay { get; set; }

    public DateTime EndDay { get; set; }

    public decimal Salary { get; set; }

    public int PostsId { get; set; }

    public virtual Post Posts { get; set; } = null!;

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();

    public virtual Worker Worker { get; set; } = null!;
}
