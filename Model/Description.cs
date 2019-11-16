using System;

namespace Model
{
    public class Description
    {
        public Guid Id { get; set; }
        public Game GameId { get; set; }
        public Guid Game { get; set; }
        public string Content { get; set; }
        public int Language { get; set; }
    }
}