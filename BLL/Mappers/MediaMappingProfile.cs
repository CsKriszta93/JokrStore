using AutoMapper;
using BLL.DTO;
using Model;

namespace BLL.Mappers
{
    public class MediaMappingProfile : Profile
    {
        public MediaMappingProfile()
        {
            CreateMap<MediaDto, Media>()
                .ForMember(m => m.Id, opt => opt.MapFrom(d => d.Id))
                .ForMember(m => m.GameId, opt => opt.MapFrom(d => d.GameId))
                .ForMember(m => m.type, opt => opt.MapFrom(d => d.type))
                .ForMember(m => m.contain, opt => opt.MapFrom(d => d.contain))
                .ReverseMap();
        }
    }
}
