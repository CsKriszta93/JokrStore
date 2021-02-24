using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Model
{
    public class Role : IdentityRole<Guid>
    {
        public ICollection<UserRole> UserRoles{ get; set; }
    }
}
