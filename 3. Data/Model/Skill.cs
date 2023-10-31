using System;
using System.Collections.Generic;

namespace _3._Data.Model;

public partial class Skill : ModelBase
{
    public int WorkerId { get; set; }

    public string Content { get; set; } = null!;

    public virtual Worker Worker { get; set; } = null!;
}
