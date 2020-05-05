using AutoMapper;
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
                .ForMember(m => m.DownloadLink, opt => opt.MapFrom(d => d.DownloadLink))
                .ForMember(m => m.GameName, opt => opt.MapFrom(d => d.GameName))
                .ForMember(m => m.NumOfDownloads, opt => opt.MapFrom(d => d.NumOfDownloads))
                .ForMember(m => m.Price, opt => opt.MapFrom(d => d.Price))
                .ForMember(m => m.Rate, opt => opt.MapFrom(d => d.Rate))
                .ForMember(m => m.Release, opt => opt.MapFrom(d => d.Release))
                .ForMember(m => m.Publish, opt => opt.MapFrom(d => d.Publish))
                .ForMember(m => m.State, opt => opt.MapFrom(d => d.State))
                .ForMember(m => m.ReleaseState, opt => opt.MapFrom(d => d.ReleaseState))
                .ForMember(m => m.CoverArt, opt => opt.MapFrom(d => d.CoverArt))
                .ForMember(m => m.UserId, opt => opt.MapFrom(d => d.UserId))
                .ForMember(m => m.MinSysReqId, opt => opt.MapFrom(d => d.MinSysReqId))
                .ForMember(m => m.RecSysReqId, opt => opt.MapFrom(d => d.RecSysReqId))
                .ForMember(m => m.SysReqNotes, opt => opt.MapFrom(d => d.SysReqNotes))
                .ReverseMap();

            CreateMap<GameProperty, GamePropertyDto>();
            CreateMap<UserGames, UserGamesDto>();
            CreateMap<Description, DescriptionDto>();
        }        
    }
}