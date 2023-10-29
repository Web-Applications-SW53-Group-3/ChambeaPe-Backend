using System;
using System.Collections.Generic;

namespace _3._Data.Model;

public partial class Portfolio : ModelBase
{
    public int ImageUrl { get; set; }

    public int WorkerId { get; set; }

    public virtual Worker Worker { get; set; } = null!;
}
