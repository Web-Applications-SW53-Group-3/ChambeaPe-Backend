using _1._API.Request;
using _3._Data.Model;
using AutoMapper;

namespace _1._API.Mapper
{
    public class APIToModel : Profile
    {
        public APIToModel() {
            CreateMap<UserRequest, User>();
            CreateMap<WorkerRequest, Worker>();
            CreateMap<WorkerRequest, User>();
            CreateMap<WorkerRequest, UserRequest>();
            CreateMap<AdvertisementRequest, Advertisement>();
            CreateMap<CertificateRequest, Certificate>();
            CreateMap<PortfolioRequest, Portfolio>();
            CreateMap<SkillRequest, Skill>();
        }
    }
}
