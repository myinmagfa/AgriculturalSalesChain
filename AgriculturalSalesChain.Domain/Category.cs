using AgriculturalSalesChain.Domain.Common;

namespace AgriculturalSalesChain.Models
{
    public class Category: BaseDomainEntitiy
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}