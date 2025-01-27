using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgriculturalSalesChain.Application.DTOs;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Inventories.Requests.Queries
{
    public class GetInventoryListRequest:IRequest<List<InventoryDto>>
    {
        
    }
}
