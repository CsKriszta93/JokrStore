using System;
using System.Collections.Generic;

namespace Model
{
    public class GameProperty
    {
        public Guid Id { get; set; }
        public Guid GameId { get; set; }
        public Game Game { get; set; }
        public Guid PropertyId { get; set; }
        public Property Property { get; set; }

    }
}