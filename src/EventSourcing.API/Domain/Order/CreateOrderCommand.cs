using EventSourcing.API.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace EventSourcing.API.Domain.Order
{
    public class CreateOrderCommand : IRequest<CreateOrderResultModel>
    {
        public OrderStatus Status { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public decimal Price { get; set; }
        public string CreatedBy { get; set; }
    }
}
