using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace DAL.EntityConfigurations
{
    internal class MediaConfiguration : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            builder.HasOne(m => m.game)
               .WithMany(g => g.Medias)
               .HasForeignKey(m => m.GameId);
        }
    }
}
