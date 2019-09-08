using AutoMapper;
using AutoMapper.QueryableExtensions;
using BLL.DTO;
using BLL.ServiceInterfaces;
using JOKRStore.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Model;


namespace BLL.Services
{
    public class ForumService : IForumService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public ForumService(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ForumCategoryDto>> GetForumCategories()
        {
            var categories = await dbContext.ForumCategories.ToListAsync<ForumCategory>();
            return mapper.Map<List<ForumCategoryDto>>(categories);
        }

        public async Task<ForumCategoryDto> GetForumCategoryByIdAsync(Guid id)
        {
            var category = await dbContext.ForumCategories
            .Include(x => x.topics)
            .FirstOrDefaultAsync(x => x.Id == id);
            return mapper.Map<ForumCategoryDto>(category);
        }

        public async Task<ForumTopicDto> GetForumTopicByIdAsync(Guid id)
        {
            var topic = await dbContext.ForumTopics
            .Include(x => x.User)
            .Include(x => x.Comments)
            .FirstOrDefaultAsync(x => x.Id == id);

            return mapper.Map<ForumTopicDto>(topic);
        }

        public async Task AddNewTopicAsync(Guid UserId, Guid CategoryId, string title, string content)
        {
                ForumTopicDto new_topic = new ForumTopicDto
                {
                    UserId = UserId,
                    ForumCategoryId = CategoryId,
                    title = title,
                    content = content,
                    date = DateTime.Now

                };

                dbContext.ForumTopics.Add(mapper.Map<ForumTopic>(new_topic));
                await dbContext.SaveChangesAsync();
        }
    }
}
