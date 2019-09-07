using AutoMapper;
using BLL.DTO;
using Model;
using JOKRStore.Web.ViewModels;

namespace BLL.Mappers
{
    public class ConfigMappingProfile : Profile
    {
        public ConfigMappingProfile()
        {
            CreateMap<ConfigViewModel, ConfigDto>()
                .ReverseMap();   
        }
    }
}