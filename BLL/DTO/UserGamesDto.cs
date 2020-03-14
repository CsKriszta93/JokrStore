using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class UserGamesDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public UserDto User { get; set; }
        public Guid GameId { get; set; }
        public GameDto Game { get; set; }
    }
}
