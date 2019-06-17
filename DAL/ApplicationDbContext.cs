using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model;
using System;

namespace JOKRStore.DAL
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /* protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             base.OnModelCreating(modelBuilder);

             modelBuilder.Entity<Comment>()
                 .HasOne(c => c.Game)
                 .WithMany(g => g.Comments)
                 .HasForeignKey(c => c.GameId)
                 .HasConstraintName("ForeginKey_Comment_Game");

             modelBuilder.Entity<Comment>()
                 .HasOne(c => c.User)
                 .WithMany(u => u.comments)
                 .HasForeignKey(c => c.Commenter)
                 .HasConstraintName("ForeignKey_Comment_User");


         }*/

        public DbSet<Game> Games { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<UserGames> UserGames { get; set; }
    }
}
