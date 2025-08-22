using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Core.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string? Description { get; set; } = null;
        public ICollection<Product>? Products { get; set; } = null;
    }
}