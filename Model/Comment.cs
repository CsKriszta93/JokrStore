using System;

namespace Model
{
    public class Comment
    {
        public Guid Id { get; set; }
        public DateTime CommentDate { get; set; }
        public string Contain { get; set; }

        public Guid GameId { get; set; }
        public Game Game { get; set; }

        public User User { get; set; }
        public Guid UserId { get; set; }
    }
}
