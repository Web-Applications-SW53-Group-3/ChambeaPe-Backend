using System;
using System.Collections.Generic;

namespace _3._Data.Model;

public partial class Review : ModelBase
{
    public int EmployerId { get; set; }

    public int WorkerId { get; set; }

    public int Rating { get; set; }

    public string Description { get; set; } = null!;

    public DateTime Date { get; set; }

    public int SentById { get; set; }

    public virtual Employer Employer { get; set; } = null!;

    public virtual Worker Worker { get; set; } = null!;
}
