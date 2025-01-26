using AgriculturalSalesChain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgriculturalSalesChain.Application.DTOs.Common;

namespace AgriculturalSalesChain.Application.DTOs
{
    public class OrderDto:BaseDto
    {
        public string UserId { get; set; }
        public ApplicationUserDto User { get; set; }
        public int ProductId { get; set; }
        public ProductDto Product { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
