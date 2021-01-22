using EventSourcing.API.Domain.Order;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace EventSourcing.API.Controllers
{
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<CreateOrderResultModel> Create(CreateOrderModel createOrderModel, CancellationToken ct)
        {
            var result = await _mediator.Send(new CreateOrderCommand
            {
                CreatedBy = "System",
                OrderItems = createOrderModel.OrderItems,
                Price = createOrderModel.Price,
                Status = createOrderModel.Status
            }, ct);

            return result;
        }

    }
}
