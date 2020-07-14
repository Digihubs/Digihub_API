using DigiHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiHub.Persistence.Configurations
{
    public class OrderDetailEntityConfiguration : IEntityTypeConfiguration<OrderDetailsEntity>
    {
        public void Configure(EntityTypeBuilder<OrderDetailsEntity> builder)
        {
            builder.ToTable("OrderDetail");

            builder
                .HasOne(o => o.OrdersEntity)
                .WithMany(od => od.OrderDetailsEntities)
                .HasForeignKey(o => o.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(cws => cws.CategoryWiseServiceEntity)
                .WithMany(od => od.OrderDetailsEntities)
                .HasForeignKey(cws => cws.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
