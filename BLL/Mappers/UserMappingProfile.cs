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
                .ForMember(m => m.Registration, opt => opt.MapFrom(d => d.Registration))
                .ForMember(m => m.LastLogin, opt => opt.MapFrom(d => d.LastLogin))
                .ForMember(m => m.IsAdmin, opt => opt.MapFrom(d => d.IsAdmin));
        }
    }
}