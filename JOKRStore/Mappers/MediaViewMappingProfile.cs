using AutoMapper;
using BLL.DTO;
using JOKRStore.Web.ViewModels;
using System;

namespace JOKRStore.Web.Mappers
{
    public class MediaViewMappingProfile : Profile
    {
        public MediaViewMappingProfile()
        {
            CreateMap<MediaViewModel, MediaDto>()
                .ForMember(m => m.Id, opt => opt.MapFrom(d => d.Id))
                .ForMember(m => m.GameId, opt => opt.MapFrom(d => d.GameId))
                .ForMember(m => m.type, opt => opt.MapFrom(d => d.type))
                .ForMember(m => m.contain, opt => opt.MapFrom(d => d.contain))
                .ReverseMap();
        }
       
    }
}
