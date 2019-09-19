using AutoMapper;
using BLL.DTO;
using JOKRStore.Web.ViewModels;

namespace JOKRStore.Web.Mappers
{
    public class UserViewMappingProfile : Profile
    {
        public UserViewMappingProfile()
        {
            CreateMap<UserDto, UserViewModel>()
                 .ForMember(m => m.Id, opt => opt.MapFrom(d => d.Id))
                 .ForMember(m => m.UserName, opt => opt.MapFrom(d => d.UserName))
                 .ForMember(m => m.Registration, opt => opt.MapFrom(d => d.Registration))
                 .ForMember(m => m.LastLogin, opt => opt.MapFrom(d => d.LastLogin))
                 .ForMember(m => m.IsAdmin, opt => opt.MapFrom(d => d.IsAdmin));
        }
    }
}
