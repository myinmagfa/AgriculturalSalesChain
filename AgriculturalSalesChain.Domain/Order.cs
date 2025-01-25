using AgriculturalSalesChain.Domain.Common;

namespace AgriculturalSalesChain.Models
{
    public class Order: BaseDomainEntitiy
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
    }
}