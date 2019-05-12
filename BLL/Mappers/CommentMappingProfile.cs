using AutoMapper;
using BLL.DTO;
using Model;

namespace BLL.Mappers
{
    public class CommentMappingProfile : Profile
    {
        public CommentMappingProfile()
        {
            CreateMap<Comment, CommentDto>()
                .ForMember(b => b.CommenterId, opt => opt.MapFrom(c => c.User.Id))
                .ForMember(b => b.Contain, opt => opt.MapFrom(c => c.Contain))
                .ForMember(b => b.CommentDate, opt => opt.MapFrom(c => c.CommentDate))
                //.ForMember(b => b.User, opt => opt.MapFrom(c => c.User))
                .ForMember(b => b.GameId, opt => opt.MapFrom(c => c.Game.Id))
                .ReverseMap();
        }
    }
}
