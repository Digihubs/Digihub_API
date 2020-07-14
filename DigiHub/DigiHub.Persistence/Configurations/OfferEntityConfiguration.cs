using DigiHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiHub.Persistence.Configurations
{
    public class OfferEntityConfiguration : IEntityTypeConfiguration<OfferEntity>
    {
        public void Configure(EntityTypeBuilder<OfferEntity> builder)
        {
            builder.ToTable("Offer");
        }
    }
}
