using _1._API.Request;
using _1._API.Response;
using _3._Data.Model;
using AutoMapper;

namespace _1._API.Mapper
{
    public class ModelToAPI : Profile
    {
        public ModelToAPI() {
            CreateMap<User, UserRequest>();
            CreateMap<User, UserResponse>();
            CreateMap<Worker, WorkerResponse>()
                .ForMember(dest => dest.WorkerId, opt => opt.MapFrom(src => src.Id));
            CreateMap<Certificate, CertificateResponse>();
            CreateMap<Skill, SkillResponse>();
            CreateMap<Portfolio, PortfolioResponse>();
            CreateMap<Advertisement, AdvertisementResponse>();
            CreateMap<Review, ReviewResponse>();
        }
    }
}
