using System;
using System.Collections.Generic;

namespace BLL.DTO.UserDtos
{
    public class UserDto
    {  
        /*public string Password { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }*/
        public Guid Id { get; set; }
        public DateTime Registration { get; set; }
        public string BankAccount { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime LastLogin { get; set; }
        public string UserName { get; set; }
        /// <summary>
        /// idegen kulcs a Configuraton táblához
        /// </summary>
        public List<CommentDto> Comments { get; set; }
        public List<UserGamesDto> UserGames { get; set; }
        public List<GameDto> Games { get; set; }
        public ConfigDto Config { get; set; }
    }
}
