using System;
using System.Collections.Generic;

namespace _3._Data.Model;

public partial class Chat : ModelBase
{

    public int WorkerId { get; set; }

    public int EmployerId { get; set; }

    public DateTime CreationTime { get; set; }

    public int MessageId { get; set; }

    public virtual ICollection<Claim> Claims { get; set; } = new List<Claim>();

    public virtual Employer Employer { get; set; } = null!;

    public virtual Message Message { get; set; } = null!;

    public virtual Worker Worker { get; set; } = null!;
}
