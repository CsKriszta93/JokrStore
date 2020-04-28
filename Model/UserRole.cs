using Microsoft.AspNetCore.Identity;
using System;

namespace Model
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
