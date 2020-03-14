using System;

namespace JOKRStore.Web.ViewModels
{
    public class UserGamesViewModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public UserViewModel User { get; set; }
        public Guid GameId { get; set; }
        public GameViewModel Game { get; set; }
    }
}
