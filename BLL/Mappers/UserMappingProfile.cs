using AutoMapper;
using BLL.DTO;
using Model;

namespace BLL.Mappers
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(m => m.Id, opt => opt.MapFrom(d => d.Id))
                .ForMember(m => m.UserName, opt => opt.MapFrom(d => d.UserName))
                .ForMember(m => m.Registration, opt => opt.MapFrom(d => d.Registration.ToString("yyyy-MM-dd HH:mm")))
                .ForMember(m => m.LastLogin, opt => opt.MapFrom(d => d.LastLogin.ToString("yyyy-MM-dd HH:mm")))
                .ForMember(m => m.IsAdmin, opt => opt.MapFrom(d => d.IsAdmin));

            CreateMap<User, UserRegisterDto>()
                .ForMember(m => m.UserName, opt => opt.MapFrom(d => d.UserName))
                .ForMember(m => m.Email, opt => opt.MapFrom(d => d.Email))
                .ForMember(m => m.Password, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<User, UserDtoLite>()
                .ForMember(m => m.Id, opt => opt.MapFrom(d => d.Id))
                .ForMember(m => m.UserName, opt => opt.MapFrom(d => d.UserName));
        }
    }
}