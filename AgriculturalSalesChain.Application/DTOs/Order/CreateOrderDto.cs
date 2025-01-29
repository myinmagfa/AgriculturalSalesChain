using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgriculturalSalesChain.Application.DTOs.Common;
using AgriculturalSalesChain.Application.DTOs.Product;

namespace AgriculturalSalesChain.Application.DTOs.Order
{
    public class CreateOrderDto:BaseDto
    {
        public string UserId { get; set; }
        public ApplicationUserDto User { get; set; }
        public int ProductId { get; set; }
        public ProductDto Product { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
