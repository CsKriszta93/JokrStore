using BLL.DTO.UserDtos;
using System;

namespace BLL.DTO
{
    public class CommentDto
    {
        public Guid CommenterId { get; set; }

        public DateTime CommentDate { get; set; }

        public string Contain { get; set; }

        public Guid GameId { get; set; }
    }
}
