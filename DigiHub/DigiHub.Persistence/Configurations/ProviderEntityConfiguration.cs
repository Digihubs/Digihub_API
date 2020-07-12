using DigiHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiHub.Persistence.Configurations
{
    public class ProviderEntityConfiguration : IEntityTypeConfiguration<ProvidersEntity>
    {
        public void Configure(EntityTypeBuilder<ProvidersEntity> builder)
        {
            builder.ToTable("Provider");

            builder
                .HasOne(a => a.AddressEntity)
                .WithMany(p => p.ProvidersEntities)
                .HasForeignKey(a => a.AddressId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
