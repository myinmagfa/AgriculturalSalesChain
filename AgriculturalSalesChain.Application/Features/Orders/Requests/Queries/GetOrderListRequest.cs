using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgriculturalSalesChain.Application.DTOs.Order;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Orders.Requests.Queries
{
    public class GetOrderListRequest:IRequest<List<OrderDto>>
    {

    }
}
