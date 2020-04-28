using System;

namespace Model
{
    public class Description
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public int Language { get; set; }

        public Guid GameId { get; set; }
        public Game Game { get; set; }
    }
}