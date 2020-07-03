using DigiHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DigiHub.Persistence
{
    public class DigiHubDBContext : DbContext
    {
        public DigiHubDBContext()
        {

        }

        public DbSet<CategoryEntity> CategoryEntities { get; set; }
        public DbSet<ServiceEntity> ServiceEntities { get; set; }
        public DbSet<CategoryWiseServiceEntity> WiseServiceEntities { get; set; }
        public DbSet<AddressEntity> AddressEntities { get; set; }
        public DbSet<ProvidersEntity> ProvidersEntities { get; set; }
        public DbSet<ClientEntity> ClientEntities { get; set; }
        public DbSet<OrdersEntity> OrdersEntities { get; set; }
        public DbSet<OrderDetailsEntity> OrderDetailsEntities { get; set; }
        public DbSet<TransactionEntity> TransactionEntities { get; set; }
        public DbSet<AssignProversToServiceEntity> AssignProversToServiceEntities { get; set; }
        public DbSet<OfferEntity> OfferEntities { get; set; }
        public CommissionEntity CommissionEntity { get; set; }
        public DbSet<ValuesEntity> ValuesEntities { get; set; }
    }
}
