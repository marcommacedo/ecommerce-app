using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Core.Enums;

namespace ECommerce.Core.Entities
{
    public class Order : BaseEntity
    {
        public Guid UserId { get; set; }
        public Customer? User { get; set; } = null;
        public Guid AddressId { get; set; }
        public Address? Address { get; set; } = null;
        public OrderStatus OrderStatus { get; set; } = OrderStatus.PENDING;
        public decimal TotalAmount { get; set; }
        public ICollection<OrderItem>? Items { get; set; } = null;
    }
}