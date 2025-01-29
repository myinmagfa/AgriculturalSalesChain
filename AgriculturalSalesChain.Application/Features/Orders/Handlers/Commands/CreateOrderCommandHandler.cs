using AgriculturalSalesChain.Application.Features.Orders.Requests.Commands;
using AgriculturalSalesChain.Application.Persistence.Contracts;
using AgriculturalSalesChain.Domain;
using AutoMapper;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Orders.Handlers.Commands
{
    public class CreateOrderCommandHandler:IRequestHandler<CreateOrderCommand,int >
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public CreateOrderCommandHandler(IOrderRepository orderRepository,IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = _mapper.Map<Order>(request.OrderDto);
            order = await _orderRepository.Add(order);
            return order.Id;
        }
    }
}
