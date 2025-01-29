using AgriculturalSalesChain.Application.DTOs.Order;
using AgriculturalSalesChain.Application.Features.Orders.Requests.Queries;
using AgriculturalSalesChain.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Orders.Handlers.Queries
{
    public class GetOrderDetailRequestHandler:IRequestHandler<GetOrderDetailRequest,OrderDto>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public GetOrderDetailRequestHandler(IOrderRepository orderRepository,IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<OrderDto> Handle(GetOrderDetailRequest request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetAsync(request.Id);
            return _mapper.Map<OrderDto>(order);
        }
    }
}
