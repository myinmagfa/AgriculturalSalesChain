using AgriculturalSalesChain.Application.DTOs.Order;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Orders.Requests.Commands
{
    public class CreateOrderCommand : IRequest<int>
    {
        public OrderDto OrderDto { get; set; }
    }
}
