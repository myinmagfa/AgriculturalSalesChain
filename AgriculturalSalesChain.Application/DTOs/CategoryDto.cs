using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgriculturalSalesChain.Application.DTOs.Common;
using AgriculturalSalesChain.Domain;

namespace AgriculturalSalesChain.Application.DTOs
{
    public class CategoryDto:BaseDto
    {
        public string Name { get; set; }
        public ICollection<ProductDto> Products { get; set; }
    }
}
