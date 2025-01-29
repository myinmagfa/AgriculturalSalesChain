using AgriculturalSalesChain.Application.DTOs.Common;
using AgriculturalSalesChain.Application.DTOs.Product;

namespace AgriculturalSalesChain.Application.DTOs.Category
{
    public class CreateCategoryDto:BaseDto
    {
        public string Name { get; set; }
        public ICollection<ProductDto> Products { get; set; }
    }
}
