using DigiHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace DigiHub.Application.Common.Interfaces
{
    public interface IDigiHubDBContext
    {
        DbSet<CategoryEntity> CategoryEntities { get; set; }
        DbSet<ServiceEntity> ServiceEntities { get; set; }
        DbSet<CategoryWiseServiceEntity> CategoryWiseServiceEntities { get; set; }
        DbSet<AddressEntity> AddressEntities { get; set; }
        DbSet<ProvidersEntity> ProvidersEntities { get; set; }
        DbSet<ClientEntity> ClientEntities { get; set; }
        DbSet<OrdersEntity> OrdersEntities { get; set; }
        DbSet<OrderDetailsEntity> OrderDetailsEntities { get; set; }
        DbSet<AssignProvidersToOrderEntity> AssignProvidersToOrderEntities { get; set; }
        DbSet<TransactionEntity> TransactionEntities { get; set; }
        DbSet<OfferEntity> OfferEntities { get; set; }
        DbSet<CommissionEntity> CommissionEntities { get; set; }
        DbSet<ValuesEntity> ValuesEntities { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
