using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Core.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; } = String.Empty;
        public string PasswordHash { get; set; } = String.Empty;
        public string PhoneNumber { get; set; } = String.Empty;
        public ICollection<Address>? Addresses { get; set; } = null;
        public ICollection<Order>? Orders { get; set; } = null;
    }
}