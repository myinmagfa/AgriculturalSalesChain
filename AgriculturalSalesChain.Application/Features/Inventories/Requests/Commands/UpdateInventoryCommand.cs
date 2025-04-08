using AgriculturalSalesChain.Application.DTOs.Inventory;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Inventories.Requests.Commands
{
    public class UpdateInventoryCommand:IRequest<Unit>
    {
        public InventoryDto InventoryDto { get; set; }
    }
}
