﻿using AutoMapper;
using BLL.DTO;
using Model;

namespace BLL.Mappers
{
    public class GameMappingProfile : Profile
    {
        public GameMappingProfile()
        {
            CreateMap<Game, GameDto>()
                .ForMember(m => m.Id, opt => opt.MapFrom(d => d.Id))
                .ForMember(m => m.DemoLink, opt => opt.MapFrom(d => d.DemoLink))
                .ForMember(m => m.Description, opt => opt.MapFrom(d => d.Description))
                .ForMember(m => m.DownloadLink, opt => opt.MapFrom(d => d.DownloadLink))
                .ForMember(m => m.GameName, opt => opt.MapFrom(d => d.GameName))
                .ForMember(m => m.NumOfDownloads, opt => opt.MapFrom(d => d.NumOfDownloads))
                .ForMember(m => m.Price, opt => opt.MapFrom(d => d.Price))
                .ForMember(m => m.Rate, opt => opt.MapFrom(d => d.Rate))
                .ForMember(m => m.Release, opt => opt.MapFrom(d => d.Release))
                .ForMember(m => m.CoverArt, opt => opt.MapFrom(d => d.CoverArt))
                .ForMember(m => m.Developer, opt => opt.MapFrom(d => d.Developer));
        }        
    }
}
