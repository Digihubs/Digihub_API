using DigiHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiHub.Persistence.Configurations
{
    public class AssignProviderToOrderEntityConfiguration : IEntityTypeConfiguration<AssignProvidersToOrderEntity>
    {
        public void Configure(EntityTypeBuilder<AssignProvidersToOrderEntity> builder)
        {
            builder.ToTable("AssignProviderToOrder");

            builder
                .HasOne(p => p.ProvidersEntity)
                .WithMany(aps => aps.AssignProvidersToOrderEntities)
                .HasForeignKey(p => p.ProviderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(o => o.OrdersEntity)
                .WithMany(aps => aps.AssignProvidersToOrderEntities)
                .HasForeignKey(o => o.OrderId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
