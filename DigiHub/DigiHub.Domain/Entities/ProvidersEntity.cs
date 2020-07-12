using DigiHub.Domain.Common;
using System.Collections.Generic;

namespace DigiHub.Domain.Entities
{
    public class ProvidersEntity : AuditableEntity
    {
        public ProvidersEntity()
        {
            AssignProvidersToOrderEntities = new HashSet<AssignProvidersToOrderEntity>();
            TransactionEntities = new HashSet<TransactionEntity>();
        }
        public int Id { get; set; }
        public string ProviderName { get; set; }
        public string ProviderCode { get; set; }
        public string ContactNumber { get; set; }
        public string BusinessAddress { get; set; }
        public int AddressId { get; set; }
        public AddressEntity AddressEntity { get; set; }
        public bool IsIndividual { get; set; }
        public ICollection<AssignProvidersToOrderEntity> AssignProvidersToOrderEntities { get; private set; }
        public ICollection<TransactionEntity> TransactionEntities { get; private set; }

    }
}
