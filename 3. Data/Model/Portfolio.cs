using System;
using System.Collections.Generic;

namespace _3._Data.Model;

public partial class Portfolio : ModelBase
{
    public string ImageUrl { get; set; } = null!;

    public int WorkerId { get; set; }

    public virtual Worker Worker { get; set; } = null!;
}
