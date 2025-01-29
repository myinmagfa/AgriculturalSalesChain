using AgriculturalSalesChain.Application.DTOs.Order;
using AgriculturalSalesChain.Application.Features.Orders.Requests.Queries;
using AgriculturalSalesChain.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Orders.Handlers.Queries
{
    public class GetOrderListRequestHandler:IRequestHandler<GetOrderListRequest,List<OrderDto>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public GetOrderListRequestHandler(IOrderRepository orderRepository,IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<List<OrderDto>> Handle(GetOrderListRequest request, CancellationToken cancellationToken)
        {
            var orderList = await _orderRepository.GetAllAsync();
            return _mapper.Map<List<OrderDto>>(orderList);
        }
    }
}
