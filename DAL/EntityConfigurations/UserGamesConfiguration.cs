using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace DAL.EntityConfigurations
{
    internal class UserGamesConfiguration : IEntityTypeConfiguration<UserGames>
    {
        public void Configure(EntityTypeBuilder<UserGames> builder)
        {
            builder.HasKey(x => new { x.UserId, x.GameId });

            builder.HasOne(ug => ug.User)
                .WithMany(u => u.UserGames);

            builder.HasOne(ug => ug.Game)
                .WithMany(g => g.UserGames);
        }
    }
}
