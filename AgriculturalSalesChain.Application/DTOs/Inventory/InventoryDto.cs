using AgriculturalSalesChain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgriculturalSalesChain.Application.DTOs.Common;
using AgriculturalSalesChain.Application.DTOs.Product;

namespace AgriculturalSalesChain.Application.DTOs.Inventory
{
    public class InventoryDto : BaseDto
    {
        public int ProductId { get; set; }
        public ProductDto Product { get; set; }
        public int Quantity { get; set; }
        public string Location { get; set; }
    }
}
