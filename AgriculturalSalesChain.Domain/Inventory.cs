using AgriculturalSalesChain.Domain.Common;

namespace AgriculturalSalesChain.Models
{
    public class Inventory: BaseDomainEntitiy
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public string Location { get; set; }
    }
}