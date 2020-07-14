using DigiHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiHub.Persistence.Configurations
{
    public class OrderEntityConfiguration : IEntityTypeConfiguration<OrdersEntity>
    {
        public void Configure(EntityTypeBuilder<OrdersEntity> builder)
        {
            builder.ToTable("Order");

            builder
                .HasOne(c => c.ClientEntity)
                .WithMany(o => o.OrdersEntities)
                .HasForeignKey(c => c.ClientId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
