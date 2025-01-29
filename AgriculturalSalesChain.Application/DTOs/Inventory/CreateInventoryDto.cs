using AgriculturalSalesChain.Application.DTOs.Common;
using AgriculturalSalesChain.Application.DTOs.Product;

namespace AgriculturalSalesChain.Application.DTOs.Inventory
{
    public class CreateInventoryDto:BaseDto
    {
        public int ProductId { get; set; }
        public ProductDto Product { get; set; }
        public int Quantity { get; set; }
        public string Location { get; set; }
    }
}
