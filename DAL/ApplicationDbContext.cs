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

         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             base.OnModelCreating(modelBuilder);

             modelBuilder.Entity<GameProperty>()
             .HasKey(x => new {x.GameId, x.PropertyId} );

             modelBuilder.Entity<GameProperty>()
             .HasOne(gp => gp.Game)
             .WithMany(g => g.Genres)
             .HasForeignKey(gp => gp.GameId);

             modelBuilder.Entity<GameProperty>()
             .HasOne(gp => gp.Property)
             .WithMany(p => p.GameProperties)
             .HasForeignKey(gp => gp.PropertyId);

             modelBuilder.Entity<Media>()
             .HasOne(m => m.game)
             .WithMany(g => g.Medias)
             .HasForeignKey(m => m.GameId);
         }

        public DbSet<Game> Games { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<UserGames> UserGames { get; set; }
        public DbSet<ForumCategory> ForumCategories { get; set; }
        public DbSet<ForumTopic> ForumTopics { get; set; }
        public DbSet<Config> Configs { get; set; }
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<GPU> GPUs { get; set; }
        public DbSet<OS> OSes { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<GameProperty> GameProperties { get; set; }
        public DbSet<Media> Medias { get; set; }
    }
}