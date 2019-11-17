using AutoMapper;
using BLL.DTO;
using JOKRStore.Web.ViewModels;

namespace JOKRStore.Web.Mappers
{
    public class CommentViewModelMappingProfile : Profile
    {
        public CommentViewModelMappingProfile()
        {
            CreateMap<CommentDto, CommentViewModel>()
               .ForMember(b => b.CommenterId, opt => opt.MapFrom(c => c.UserId))
               .ForMember(b => b.Contain, opt => opt.MapFrom(c => c.Contain))
               .ForMember(b => b.CommentDate, opt => opt.MapFrom(c => c.CommentDate))
               .ForMember(b => b.GameId, opt => opt.MapFrom(c => c.GameId))
               .ReverseMap();
        }
    }
}
