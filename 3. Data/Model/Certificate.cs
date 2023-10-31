using System;
using System.Collections.Generic;

namespace _3._Data.Model;

public partial class Certificate : ModelBase
{

    public string Name { get; set; } = null!;

    public string ImgUrl { get; set; } = null!;

    public string InstitutionName { get; set; } = null!;

    public string TeacherName { get; set; } = null!;

    public DateTime IssueDate { get; set; }

    public string CertificateName { get; set; } = null!;

    public int WorkerId { get; set; }

    public virtual Worker Worker { get; set; } = null!;
}
