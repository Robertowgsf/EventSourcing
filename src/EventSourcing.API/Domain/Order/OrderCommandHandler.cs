using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EventSourcing.API.Domain.Order
{
    public class OrderCommandHandler : IRequestHandler<CreateOrderCommand, CreateOrderResultModel>
    {
        public Task<CreateOrderResultModel> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
