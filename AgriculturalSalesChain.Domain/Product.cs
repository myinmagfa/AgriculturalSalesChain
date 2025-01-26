﻿using AgriculturalSalesChain.Domain.Common;

namespace AgriculturalSalesChain.Domain
{
    public class Product: BaseDomainEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}