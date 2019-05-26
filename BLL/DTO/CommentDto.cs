using System;

namespace BLL.DTO
{
    public class CommentDto
    {
        public Guid UserId { get; set; }

        public DateTime CommentDate { get; set; }

        public string Contain { get; set; }

        public Guid GameId { get; set; }

        public UserDto User { get; set; }
    }
}
