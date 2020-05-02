using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Linq;

namespace JOKRStore.DAL
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, Guid,
        IdentityUserClaim<Guid>, UserRole, IdentityUserLogin<Guid>,
        IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();

                userRole.HasOne(ur => ur.User)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();
            });

            modelBuilder.Entity<GameProperty>()
            .HasKey(x => new { x.GameId, x.PropertyId });

            modelBuilder.Entity<GameProperty>()
            .HasOne(gp => gp.Game)
            .WithMany(g => g.Genres)
            .HasForeignKey(gp => gp.GameId);

            modelBuilder.Entity<GameProperty>()
            .HasOne(gp => gp.Property)
            .WithMany(p => p.GameProperties)
            .HasForeignKey(gp => gp.PropertyId);

            modelBuilder.Entity<UserGames>()
            .HasKey(x => new { x.UserId, x.GameId });

            modelBuilder.Entity<UserGames>()
            .HasOne(ug => ug.User)
            .WithMany(u => u.UserGames);

            modelBuilder.Entity<UserGames>()
            .HasOne(ug => ug.Game)
            .WithMany(g => g.UserGames);

            modelBuilder.Entity<Media>()
            .HasOne(m => m.game)
            .WithMany(g => g.Medias)
            .HasForeignKey(m => m.GameId);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Config)
                .WithOne(c => c.User)
                .HasForeignKey<Config>(c => c.UserId);

            RestrictCascadeDelete(modelBuilder);
        }

        private void RestrictCascadeDelete(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
            .SelectMany(t => t.GetForeignKeys())
            .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }
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