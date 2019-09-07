using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User : IdentityUser<Guid>
    {
        //public Guid Id { get; set; }
        //public string UserName { get; set; }
        //public string Password { get; set; }
        //public string Email { get; set; }
        //public string Facebook { get; set; }

        public User()
            :base()
        {
            Id = Guid.NewGuid();
        }

        public DateTime Registration { get; set; }
        public string BankAccount { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime LastLogin { get; set; }

        /// <summary>
        /// idegen kulcs a Configuraton táblához
        /// </summary>
        public Guid? ConfigId { get; set; }
        public Config Config  { get; set; }

        public List<Comment> comments { get; set; }
        public List<UserGames> UserGames { get; set; }
    }
}
