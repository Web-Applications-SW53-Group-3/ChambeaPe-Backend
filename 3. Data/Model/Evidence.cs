using System;
using System.Collections.Generic;

namespace _3._Data.Model;

public partial class Evidence : ModelBase
{
    public string Image { get; set; } = null!;

    public int ClaimsId { get; set; }

    public virtual Claim Claims { get; set; } = null!;
}
