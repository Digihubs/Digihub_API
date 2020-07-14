using DigiHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiHub.Persistence.Configurations
{
    public class CategoryWiseServiceEntityConfiguration : IEntityTypeConfiguration<CategoryWiseServiceEntity>
    {
        public void Configure(EntityTypeBuilder<CategoryWiseServiceEntity> builder)
        {
            builder.ToTable("CategoryWiseService");

            builder
                .HasOne(c => c.CategoryEntity)
                .WithMany(cws => cws.CategoryWiseServiceEntities)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(s => s.ServiceEntity)
                .WithMany(cws => cws.CategoryWiseServiceEntities)
                .HasForeignKey(s => s.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
