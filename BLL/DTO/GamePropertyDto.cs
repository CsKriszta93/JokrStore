using System;
using System.Collections.Generic;

namespace BLL.DTO
{
    public class GamePropertyDto
    {
        public Guid Id { get; set; }
        public Guid GameId { get; set; }
        public GameDto Game { get; set; }
        public Guid PropertyId { get; set; }
        public PropertyDto Property { get; set; }

    }
}