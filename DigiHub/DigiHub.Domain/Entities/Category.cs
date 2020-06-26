using DigiHub.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiHub.Domain.Entities
{
    class Category : AuditableEntity
    {
        public string CategoryName { get; set; }
    }
}
