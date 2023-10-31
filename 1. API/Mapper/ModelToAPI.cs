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
                .ForMember(dest => dest.WorkerId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.User.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.User.LastName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User.Email))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.User.PhoneNumber))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.User.Description))
                .ForMember(dest => dest.Birthdate, opt => opt.MapFrom(src => src.User.Birthdate))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.User.Gender))
                .ForMember(dest => dest.UserRole, opt => opt.MapFrom(src => src.User.UserRole))
                .ForMember(dest => dest.HasPremium, opt => opt.MapFrom(src => src.User.HasPremium))
                .ForMember(dest => dest.ProfilePic, opt => opt.MapFrom(src => src.User.ProfilePic));
            CreateMap<Certificate, CertificateResponse>();
            CreateMap<Skill, SkillsResponse>();
            CreateMap<Portfolio, PortfolioResponse>();
            CreateMap<Review, ReviewResponse>();
            CreateMap<Employer, EmployerResponse>()
                .ForMember(dest => dest.EmployerId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.User.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.User.LastName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User.Email))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.User.PhoneNumber))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.User.Description))
                .ForMember(dest => dest.Birthdate, opt => opt.MapFrom(src => src.User.Birthdate))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.User.Gender))
                .ForMember(dest => dest.UserRole, opt => opt.MapFrom(src => src.User.UserRole))
                .ForMember(dest => dest.HasPremium, opt => opt.MapFrom(src => src.User.HasPremium))
                .ForMember(dest => dest.ProfilePic, opt => opt.MapFrom(src => src.User.ProfilePic));
        }
    }
}
