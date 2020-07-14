using DigiHub.Domain.Common;
using System;

namespace DigiHub.Domain.Entities
{
    public class OfferEntity : AuditableEntity
    {
        public int Id { get; set; }
        public string OfferName { get; set; }
        public string OfferCode { get; set; }
        public string OfferType { get; set; }
        public double OfferDiscount { get; set; }
        public string OfferDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
