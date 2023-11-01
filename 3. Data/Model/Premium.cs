using System;
using System.Collections.Generic;

namespace _3._Data.Model;

public partial class Premium : ModelBase
{
    public decimal Price { get; set; }

    public virtual ICollection<Suscription> Suscriptions { get; set; } = new List<Suscription>();
}
