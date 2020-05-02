using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Model
{
    public class User : IdentityUser<Guid>
    {
        //public Guid Id { get; set; }
        //public string UserName { get; set; }
        //public string Password { get; set; }
        //public string Email { get; set; }
        //public string Facebook { get; set; }

        //public User()
        //    :base()
        //{
        //    Id = Guid.NewGuid();
        //}

        public DateTime Registration { get; set; }
        public string BankAccount { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime LastLogin { get; set; }

        /// <summary>
        /// idegen kulcs a Configuraton táblához
        /// </summary>
        public Guid ConfigId { get; set; }
        public Config Config { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public virtual ICollection<UserGames> UserGames { get; set; }
        //public List<Game> Games { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
