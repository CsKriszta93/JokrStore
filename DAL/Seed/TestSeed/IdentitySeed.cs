using Microsoft.AspNetCore.Identity;
using Model;
using System.Collections.Generic;
using System.Linq;
using System;

namespace DAL.Seed.TestSeed
{
    public partial class TestSeed
    {
        private const string PASSWORD = "password";

        private static List<Role> Roles => new List<Role>
        {
            new Role { Name = "Admin"},
            new Role { Name = "Member"},
            new Role { Name = "Developer"}
        };

        private static List<User> Users => new List<User>
        {
            new User {
                UserName = "joakim.szabo",
                EmailConfirmed = true,
                Registration = DateTime.Now,
                LastLogin = DateTime.Now
            },
            new User {
                UserName = "kriszta.csere",
                EmailConfirmed = true,
                Registration = DateTime.Now,
                LastLogin = DateTime.Now
            },
            new User {
                UserName = "test.user",
                EmailConfirmed = true,
                Registration = DateTime.Now,
                LastLogin = DateTime.Now
            }
        };

        public static void SeedIdentity(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            if (!userManager.Users.Any())
            {
                SeedRoles(roleManager);
                SeedUsersWithRoles(userManager);
            }
        }

        public static void SeedUsersWithRoles(UserManager<User> userManager)
        {
            var roleNamesArray = Roles.Select(r => r.Name);

            foreach (var user in Users)
            {
                userManager.CreateAsync(user, PASSWORD).Wait();
                userManager.AddToRolesAsync(user, roleNamesArray);
            }
        }

        public static void SeedRoles(RoleManager<Role> roleManager)
        {
            foreach (var role in Roles)
            {
                roleManager.CreateAsync(role).Wait();
            }
        }
    }
}
