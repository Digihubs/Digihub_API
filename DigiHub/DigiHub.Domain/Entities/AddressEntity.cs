using DigiHub.Domain.Common;
using System;
using System.Collections.Generic;

namespace DigiHub.Domain.Entities
{
    public class AddressEntity : AuditableEntity
    {
        public AddressEntity()
        {
            ProvidersEntities = new HashSet<ProvidersEntity>();
        }
        public Guid Id { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public ICollection<ProvidersEntity> ProvidersEntities { get; private set; }
    }
}
