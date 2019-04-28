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
               .ForMember(b => b.CommenterId, opt => opt.MapFrom(c => c.CommenterId))
               .ForMember(b => b.Contain, opt => opt.MapFrom(c => c.Contain))
               .ForMember(b => b.CommentDate, opt => opt.MapFrom(c => c.CommentDate))
               .ForMember(b => b.User, opt => opt.MapFrom(c => c.User))
               .ReverseMap();
        }
    }
}
