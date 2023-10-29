using System;
using System.Collections.Generic;

namespace _3._Data.Model;

public partial class Claim : ModelBase
{
    public DateTime CreationTime { get; set; }

    public int MessageId { get; set; }

    public int ChatId { get; set; }

    public virtual Chat Chat { get; set; } = null!;

    public virtual ICollection<Evidence> Evidences { get; set; } = new List<Evidence>();

    public virtual Message Message { get; set; } = null!;
}
