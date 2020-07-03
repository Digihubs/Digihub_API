using DigiHub.Domain.Common;
using System;
using System.Collections.Generic;

namespace DigiHub.Domain.Entities
{
    public class ProvidersEntity : AuditableEntity
    {
        public ProvidersEntity()
        {
            AssignProversToServiceEntities = new HashSet<AssignProversToServiceEntity>();
        }
        public Guid Id { get; set; }
        public string ProviderName { get; set; }
        public string ProviderCode { get; set; }
        public string ContactNumber { get; set; }
        public string BusinessAddress { get; set; }
        public string AddressId { get; set; }
        public AddressEntity AddressEntity { get; set; }
        public bool IsIndividual { get; set; }
        public ICollection<AssignProversToServiceEntity> AssignProversToServiceEntities { get; set; }

    }
}
