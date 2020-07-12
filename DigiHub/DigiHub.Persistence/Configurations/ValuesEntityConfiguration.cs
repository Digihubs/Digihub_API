using DigiHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigiHub.Persistence.Configurations
{
    public class ValuesEntityConfiguration : IEntityTypeConfiguration<ValuesEntity>
    {
        public void Configure(EntityTypeBuilder<ValuesEntity> builder)
        {
            builder.ToTable("Values");
        }
    }
}
