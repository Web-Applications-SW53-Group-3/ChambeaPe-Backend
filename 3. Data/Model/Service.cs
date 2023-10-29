using System;
using System.Collections.Generic;

namespace _3._Data.Model;

public partial class Service : ModelBase
{
    public int ContractId { get; set; }

    public string State { get; set; } = null!;

    public virtual Contract Contract { get; set; } = null!;
}
