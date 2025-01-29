using AgriculturalSalesChain.Application.DTOs.Order;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Orders.Requests.Queries
{
    public class GetOrderDetailRequest : IRequest<OrderDto>
    {
        public int Id { get; set; }
    }
}
