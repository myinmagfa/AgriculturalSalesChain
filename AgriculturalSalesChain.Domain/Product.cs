using AgriculturalSalesChain.Domain.Common;

namespace AgriculturalSalesChain.Models
{
    public class Product: BaseDomainEntitiy
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}