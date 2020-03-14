using System;
using System.Collections.Generic;

namespace BLL.DTO {
    public class ForumTopicDto {
        public Guid Id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime date { get; set; }
        public Guid UserId { get; set; }
        public UserDto User { get; set;}
        public Guid ForumCategoryId { get; set; }
        public ForumCategoryDto ForumCategory { get; set; }
        public List<CommentDto> Comments { get; set; }
    }
}