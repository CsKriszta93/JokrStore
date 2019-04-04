using AutoMapper;
using BLL.DTO;
using JOKRStore.ViewModels;

namespace JOKRStore.Mappers
{
    public class GameViewMappingProfile : Profile
    {
        public GameViewMappingProfile() 
        {
            CreateMap<GameViewModel, GameDto>().ReverseMap();
        }
    }
}
