using DAL.EntityConfigurations;
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

            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new GamePropertyConfiguration());
            modelBuilder.ApplyConfiguration(new UserGamesConfiguration());
            modelBuilder.ApplyConfiguration(new MediaConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

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
        public DbSet<SysReq> SysReq { get; set; }
        public DbSet<SysReqCPU> SysReqCPU { get; set; }
        public DbSet<SysReqGPU> SysReqGPU { get; set; }
        public DbSet<SysReqOS> SysReqOS { get; set; }

    }
}