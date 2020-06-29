using DigiHub.Domain.Common;
using System;

namespace DigiHub.Domain.Entities
{
    public class OfferEntity : AuditableEntity
    {
        public int OfferId { get; set; }
        public string OfferName { get; set; }
        public ushort OfferType { get; set; }
        public decimal OfferDiscount { get; set; }
        public decimal OfferDescription { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime ExpiredDateTime { get; set; }
        public byte MaximumUses { get; set; }
    }
}
