using DigiHub.Application.Common.Interfaces;
using DigiHub.Domain.Entities;
using DigiHub.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace DigiHub.Persistence
{
    class DigiHubDBContext : DbContext, IDigiHubDBContext
    {
        public DigiHubDBContext(DbContextOptions<DigiHubDBContext> options)
        : base(options)
        {
        }

        public DbSet<CategoryEntity> CategoryEntities { get; set; }
        public DbSet<ServiceEntity> ServiceEntities { get; set; }
        public DbSet<CategoryWiseServiceEntity> CategoryWiseServiceEntities { get; set; }
        public DbSet<AddressEntity> AddressEntities { get; set; }
        public DbSet<ProvidersEntity> ProvidersEntities { get; set; }
        public DbSet<ClientEntity> ClientEntities { get; set; }
        public DbSet<OrdersEntity> OrdersEntities { get; set; }
        public DbSet<OrderDetailsEntity> OrderDetailsEntities { get; set; }
        public DbSet<AssignProvidersToOrderEntity> AssignProvidersToOrderEntities { get; set; }
        public DbSet<TransactionEntity> TransactionEntities { get; set; }
        public DbSet<OfferEntity> OfferEntities { get; set; }
        public DbSet<CommissionEntity> CommissionEntities { get; set; }
        public DbSet<ValuesEntity> ValuesEntities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryWiseServiceEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AddressEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProviderEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ClientEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AssignProviderToOrderEntityConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OfferEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CommissionEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ValuesEntityConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
