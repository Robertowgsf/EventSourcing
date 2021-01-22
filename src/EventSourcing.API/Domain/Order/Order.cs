using EventSourcing.API.Domain.Order;
using EventSourcing.Core.Domain;
using System.Collections.Generic;

namespace EventSourcing.API.Domain.Entities
{
    public class Order : Entity
    {
        public int Id { get; set; }
        public OrderStatus Status { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public decimal Price { get; set; }
    }
}
