using DigiHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiHub.Persistence.Configurations
{
    public class CommissionEntityConfiguration : IEntityTypeConfiguration<CommissionEntity>
    {
        public void Configure(EntityTypeBuilder<CommissionEntity> builder)
        {
            builder.ToTable("Commission");

            builder
                .HasOne(cws => cws.CategoryWiseServiceEntity)
                .WithMany(c => c.CommissionEntities)
                .HasForeignKey(cws => cws.ServiceId);
        }
    }
}
