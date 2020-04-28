using BLL.DTO.UserDtos;
using System;

namespace BLL.DTO
{
    public class CommentDto
    {
        public DateTime CommentDate { get; set; }

        public string Contain { get; set; }

        public Guid? GameId { get; set; }
        public GameDto Game { get; set; }

        public Guid? ForumTopicId { get; set; }
        public ForumTopicDto ForumTopic { get; set; }

        public Guid UserId { get; set; }
        public UserDto User { get; set; }
    }
}
