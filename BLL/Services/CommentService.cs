using AutoMapper;
using BLL.DTO;
using BLL.ServiceInterfaces;
using JOKRStore.DAL;
using Model;
using System;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CommentService : ICommentService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public CommentService(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task AddComment(CommentDto commentDto)
        {
            if (commentDto == null)
                throw new ArgumentNullException("commentDto is null");

            var comment = mapper.Map<Comment>(commentDto);
            dbContext.Comments.Add(comment);
            await dbContext.SaveChangesAsync();
        }
    }
}
