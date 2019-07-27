using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserGames
    {
        public UserGames()
        {
            this.Id = new Guid();
            this.UserId = Guid.Empty;
            this.GameId = Guid.Empty;
        }

        public UserGames(Guid UserId, Guid GameId)
        {
            this.Id = new Guid();
            this.UserId = UserId;
            this.GameId = GameId;
        }

        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid GameId { get; set; }
        public Game Game { get; set; }
    }
}