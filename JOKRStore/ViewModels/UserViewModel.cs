using System;
using System.Collections.Generic;

namespace JOKRStore.Web.ViewModels
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        /*public string Password { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }*/
        public DateTime Registration { get; set; }
        public string BankAccount { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime LastLogin { get; set; }

        /// <summary>
        /// idegen kulcs a Configuraton táblához
        /// </summary>
        public List<CommentViewModel> comments { get; set; }
        public List<UserGamesViewModel> UserGames { get; set; }
        public List<GameViewModel> Games { get; set; }
        public ConfigViewModel Config { get; set; }
        public bool isMyUser { get; set; }
    }
}
