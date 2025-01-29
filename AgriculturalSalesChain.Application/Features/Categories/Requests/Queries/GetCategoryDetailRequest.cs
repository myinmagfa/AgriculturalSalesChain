﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgriculturalSalesChain.Application.DTOs.Category;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Categories.Requests.Queries
{
    public class GetCategoryDetailRequest : IRequest<CategoryDto>
    {
        public int Id { get; set; }
    }
}
