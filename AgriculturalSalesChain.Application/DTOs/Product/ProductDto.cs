using AgriculturalSalesChain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgriculturalSalesChain.Application.DTOs.Common;
using AgriculturalSalesChain.Application.DTOs.Category;

namespace AgriculturalSalesChain.Application.DTOs.Product
{
    public class ProductDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public CategoryDto Category { get; set; }
    }
}
