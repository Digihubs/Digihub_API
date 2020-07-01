using Microsoft.EntityFrameworkCore;
using DigiHub.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace DigiHub.Application.Common.Interfaces
{
    public interface IDigiHubDBContext
    {
        DbSet<CategoryEntity> Categories { get; set; }
        DbSet<AddressEntity> Addresses { get; set; }
        DbSet<CategoryWiseServiceEntity> CategoryWiseServices { get; set; }
        DbSet<ClientEntity> Clients { get; set; }
        DbSet<CommissionEntity> Commissions { get; set; }
        DbSet<OfferEntity> Offers { get; set; }
        DbSet<OrdersEntity> Orders { get; set; }
        DbSet<OrderDetailsEntity> OrderDetails { get; set; }
        DbSet<ProvidersEntity> Providers { get; set; }
        DbSet<ServiceEntity> Services { get; set; }
        DbSet<TransactionEntity> Transactions { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
