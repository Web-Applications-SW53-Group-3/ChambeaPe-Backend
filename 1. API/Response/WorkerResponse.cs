using _3._Data.Model;

namespace _1._API.Response
{
    public class WorkerResponse
    {
        public int WorkerId { get; set; }
        public virtual UserResponse User { get; set; } = null!;
        public string Occupation { get; set; } = null!;
        public virtual List<CertificateResponse> Certificates { get; set; } = null!;
        public virtual List<PortfolioResponse> Portfolio {get; set;} = null!;
        public virtual List<SkillsResponse> Skills {get; set;} = null!;
        public virtual List<ReviewResponse> Reviews { get; set; } = null!;
    }
}
