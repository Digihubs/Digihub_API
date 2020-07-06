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
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<AddressEntity> Addresses { get; set; }
        public DbSet<CategoryWiseServiceEntity> CategoryWiseServices { get; set; }
        public DbSet<ClientEntity> Clients { get; set; }
        public DbSet<CommissionEntity> Commissions { get; set; }
        public DbSet<OfferEntity> Offers { get; set; }
        public DbSet<OrdersEntity> Orders { get; set; }
        public DbSet<OrderDetailsEntity> OrderDetails { get; set; }
        public DbSet<ProvidersEntity> Providers { get; set; }
        public DbSet<ServiceEntity> Services { get; set; }
        public DbSet<TransactionEntity> Transactions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryEntityConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
