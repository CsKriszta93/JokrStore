using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace DAL.EntityConfigurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<Config>
    {
        public void Configure(EntityTypeBuilder<Config> builder)
        {
            builder.HasOne(c => c.User)
                .WithMany(u => u.Configs)
                .HasForeignKey(c => c.UserId);
        }
    }
}
