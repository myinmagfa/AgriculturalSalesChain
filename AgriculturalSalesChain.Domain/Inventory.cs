using AgriculturalSalesChain.Domain.Common;

namespace AgriculturalSalesChain.Domain
{
    public class Inventory: BaseDomainEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public string Location { get; set; }
    }
}