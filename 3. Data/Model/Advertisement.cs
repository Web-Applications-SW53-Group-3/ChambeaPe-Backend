using System;
using System.Collections.Generic;

namespace _3._Data.Model;

public partial class Advertisement : ModelBase
{
    public string Category { get; set; } = null!;

    public string Text { get; set; } = null!;

    public DateTime StartDay { get; set; }

    public DateTime EndDay { get; set; }

    public string PictureUrl { get; set; } = null!;

    public int WorkerId { get; set; }

    public virtual Worker Worker { get; set; } = null!;
}
