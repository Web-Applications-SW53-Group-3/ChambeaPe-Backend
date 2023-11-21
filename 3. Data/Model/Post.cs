using System;
using System.Collections.Generic;

namespace _3._Data.Model;

public partial class Post : ModelBase
{
    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Subtitle { get; set; } = null!;

    public string ImgUrl { get; set; } = null!;

    public int EmployerId { get; set; }

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();
    public virtual ICollection<Postulation> Postulations { get; set; } = new List<Postulation>();

    public virtual Employer Employer { get; set; } = null!;
}
