using System;
using System.Collections.Generic;

namespace _3._Data.Model;

public partial class Worker : ModelBase
{
    public int UserId { get; set; }

    public string Occupation { get; set; } = null!;
    public virtual ICollection<Advertisement> Advertisements { get; set; } = new List<Advertisement>();

    public virtual ICollection<Certificate> Certificates { get; set; } = new List<Certificate>();

    public virtual ICollection<Chat> Chats { get; set; } = new List<Chat>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ICollection<Portfolio> Portfolios { get; set; } = new List<Portfolio>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual ICollection<Skill> Skills { get; set; } = new List<Skill>();

    public virtual User User { get; set; } = null!;
}
