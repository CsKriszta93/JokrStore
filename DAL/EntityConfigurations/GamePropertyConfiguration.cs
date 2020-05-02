using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace DAL.EntityConfigurations
{
    internal class GamePropertyConfiguration : IEntityTypeConfiguration<GameProperty>
    {
        public void Configure(EntityTypeBuilder<GameProperty> builder)
        {
            builder.HasKey(x => new { x.GameId, x.PropertyId });

            builder.HasOne(gp => gp.Game)
                .WithMany(g => g.Genres)
                .HasForeignKey(gp => gp.GameId);

            builder.HasOne(gp => gp.Property)
                .WithMany(p => p.GameProperties)
                .HasForeignKey(gp => gp.PropertyId);
        }
    }
}
