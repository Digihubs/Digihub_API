using DigiHub.Domain.Common;
using System.Collections.Generic;

namespace DigiHub.Domain.Entities
{
    public class ClientEntity : AuditableEntity
    {
        public ClientEntity()
        {
            OrdersEntities = new HashSet<OrdersEntity>();
        }
        public int Id { get; set; }
        public string ClientName { get; set; }
        public int AddressId { get; set; }
        public AddressEntity AsAddressEntity { get; set; }
        public string DetailAddress { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public ICollection<OrdersEntity> OrdersEntities { get; private set; }
    }
}
