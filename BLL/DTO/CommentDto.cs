using System;

namespace BLL.DTO
{
    public class CommentDto
    {
        public Guid? CommentId { get; set; }
        public UserDtoLite User { get; set; }
        public Guid? Commenter { get; set; }

        public string CommentDate { get; set; }

        public string Contain { get; set; }

        public Guid GameId { get; set; }
    }
}
