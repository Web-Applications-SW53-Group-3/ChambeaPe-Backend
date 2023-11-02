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
            CreateMap<User, User>();
            CreateMap<Worker, Worker>();
            CreateMap<EmployerRequest, Employer>();
            CreateMap<EmployerRequest, User>();
            CreateMap<EmployerRequest, UserRequest>();
            CreateMap<AdvertisementRequest, Advertisement>();
            CreateMap<CertificateRequest, Certificate>();
            CreateMap<PortfolioRequest, Portfolio>();
            CreateMap<SkillRequest, Skill>();
            CreateMap<PostRequest, Post>();
            CreateMap<Post, Post>()
                .ForMember(dest => dest.Contracts, opt => opt.Ignore())
                .ForMember(dest => dest.Employer, opt => opt.Ignore())
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
