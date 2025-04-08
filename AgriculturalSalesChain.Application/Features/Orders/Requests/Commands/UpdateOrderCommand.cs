using AgriculturalSalesChain.Application.DTOs.Order;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Orders.Requests.Commands
{
    public class UpdateOrderCommand : IRequest<Unit>
    {
        public OrderDto OrderDto { get; set; }
    }
}
