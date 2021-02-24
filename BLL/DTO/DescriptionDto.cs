using System;

namespace BLL.DTO
{
    public class DescriptionDto
    {
        public Guid Id { get; set; }
        public Guid GameId { get; set; }
        public GameDto Game { get; set; }
        public string Content { get; set; }
        public int Language { get; set; }
    }
}