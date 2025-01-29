using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgriculturalSalesChain.Application.DTOs.Inventory;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Inventories.Requests.Commands
{
    public class CreateInventoryCommand:IRequest<int>
    {
        public InventoryDto InventoryDto { get; set; }
    }
}
