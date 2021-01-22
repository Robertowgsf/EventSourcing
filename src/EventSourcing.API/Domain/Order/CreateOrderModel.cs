using EventSourcing.API.Domain.Entities;
using System.Collections.Generic;

namespace EventSourcing.API.Domain.Order
{
    public class CreateOrderModel
    {
        public OrderStatus Status { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public decimal Price { get; set; }
    }
}
