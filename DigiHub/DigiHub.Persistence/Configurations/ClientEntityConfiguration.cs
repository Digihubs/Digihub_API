using DigiHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiHub.Persistence.Configurations
{
    public class ClientEntityConfiguration : IEntityTypeConfiguration<ClientEntity>
    {
        public void Configure(EntityTypeBuilder<ClientEntity> builder)
        {
            builder.ToTable("Client");

            builder
                .HasOne(a => a.AsAddressEntity)
                .WithMany(c => c.ClientEntities)
                .HasForeignKey(a => a.AddressId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
