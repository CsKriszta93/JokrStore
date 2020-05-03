using System;
using System.Collections.Generic;

namespace BLL.DTO
{
    public class ForumTopicDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public UserDto User { get; set; }
        public Guid ForumCategoryId { get; set; }
        public ForumCategoryDto ForumCategory { get; set; }
        public List<CommentDto> Comments { get; set; }
    }
}