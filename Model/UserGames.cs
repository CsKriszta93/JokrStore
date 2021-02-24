using System;

namespace Model
{
    public class UserGames
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid GameId { get; set; }
        public Game Game { get; set; }
    }
}
