using System;
using System.Collections.Generic;

namespace _3._Data.Model;

public partial class Suscription : ModelBase
{
    public int PremiumId { get; set; }

    public int UserId { get; set; }

    public DateTime StartDay { get; set; }

    public DateTime EndDay { get; set; }
    public virtual Premium Premium { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
