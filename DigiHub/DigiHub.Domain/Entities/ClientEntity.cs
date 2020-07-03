using DigiHub.Domain.Common;
using System;
using System.Collections.Generic;

namespace DigiHub.Domain.Entities
{
    public class ClientEntity : AuditableEntity
    {
        public Guid Id { get; set; }
        public string ClientName { get; set; }
        public ICollection<OrdersEntity> OrdersEntities { get; set; }
    }
}
