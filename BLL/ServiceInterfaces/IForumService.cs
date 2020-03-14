using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces {
    public interface IForumService {
        Task<IEnumerable<ForumCategoryDto>> GetForumCategories();
        Task<ForumCategoryDto> GetForumCategoryByIdAsync(Guid id);
        Task<ForumTopicDto> GetForumTopicByIdAsync(Guid id);
        Task AddNewTopicAsync(Guid UserId, Guid CategoryId, string title, string content);
    }
    
}