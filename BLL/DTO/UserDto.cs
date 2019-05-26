using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class UserDto
    {  
        /*public string Password { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }*/
        public DateTime Registration { get; set; }
        public string BankAccount { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime LastLogin { get; set; }
        public string UserName { get; set; }
        /// <summary>
        /// idegen kulcs a Configuraton táblához
        /// </summary>
        public Guid ConfigId { get; set; }
    }
}
