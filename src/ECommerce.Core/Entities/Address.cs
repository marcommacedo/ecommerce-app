using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Core.Entities
{
    public class Address : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public Customer? Customer { get; set; } = null;
        public string Street { get; set; } = String.Empty;
        public string Number { get; set; } = String.Empty;
        public string? Complement { get; set; } = null;
        public string Neighborhood { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        public string State { get; set; } = String.Empty;
        public string ZipCode { get; set; } = String.Empty;
        public string Country { get; set; } = String.Empty;
        public bool IsDefault { get; set; }
    }
}