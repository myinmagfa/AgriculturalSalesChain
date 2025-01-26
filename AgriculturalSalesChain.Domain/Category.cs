using AgriculturalSalesChain.Domain.Common;

namespace AgriculturalSalesChain.Domain;

public class Category : BaseDomainEntity
{
    public string Name { get; set; }
    public ICollection<Product> Products { get; set; }
}