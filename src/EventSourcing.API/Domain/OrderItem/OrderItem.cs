using EventSourcing.Core.Domain;

namespace EventSourcing.API.Domain.Entities
{
    public class OrderItem : Entity
    {
        public string ProductName { get; set; }
        public string Amount { get; set; }
        public decimal Price { get; set; }
    }
}
