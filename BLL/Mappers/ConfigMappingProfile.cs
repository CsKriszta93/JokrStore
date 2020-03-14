using AutoMapper;
using BLL.DTO;
using Model;

namespace BLL.Mappers
{
    public class ConfigMappingProfile : Profile
    {
        public ConfigMappingProfile()
        {
            CreateMap<ConfigDto, Config>()
                .ReverseMap();   
        }
    }
}