using AutoMapper;
using BLL.DTO;
using BLL.ServiceInterfaces;
using JOKRStore.DAL;
using Model;
using System;
using System.Linq;
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
            try
            {
                if (commentDto != null)
                {
                    var comment = mapper.Map<Comment>(commentDto);
                    System.Diagnostics.Debug.WriteLine("Game id in service: " +comment.GameId.ToString());
                    dbContext.Comments.Add(comment); 
                    await dbContext.SaveChangesAsync();
                }

                throw new ArgumentNullException("commentDto is null");
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("An error has occour: " + e.ToString());
            }

           
        }
    }
}
