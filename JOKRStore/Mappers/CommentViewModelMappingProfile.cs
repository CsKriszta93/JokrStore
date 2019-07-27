using AutoMapper;
using BLL.DTO;
using JOKRStore.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JOKRStore.Web.Mappers
{
    public class CommentViewModelMappingProfile : Profile
    {
        public CommentViewModelMappingProfile()
        {
            CreateMap<CommentDto, CommentViewModel>()
               .ForMember(b => b.UserId, opt => opt.MapFrom(c => c.UserId))
               .ForMember(b => b.Contain, opt => opt.MapFrom(c => c.Contain))
               .ForMember(b => b.CommentDate, opt => opt.MapFrom(c => c.CommentDate.ToString("yyyy.MM.dd. hh:mm")))
               .ForMember(b => b.GameId, opt => opt.MapFrom(c => c.GameId))
               .ReverseMap()
               .ForMember(b => b.CommentDate, opt => opt.MapFrom(c => DateTime.ParseExact(c.CommentDate, "yyyy.MM.dd. hh:mm", System.Globalization.CultureInfo.InvariantCulture)));
        }
    }
}