using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserGames
    {
        public UserGames(Guid UserId, Guid GameId)
        {
            this.UserId = UserId;
            this.GameId = GameId;
        }
        Guid UserId { get; set; }
        Guid GameId { get; set; }
    }
}
