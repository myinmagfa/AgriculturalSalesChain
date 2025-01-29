using AgriculturalSalesChain.Application.DTOs.Product;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Products.Requests.Commands
{
    public class CreateProductCommand:IRequest<int>
    {
        public ProductDto ProductDto { get; set; }
    }
}
