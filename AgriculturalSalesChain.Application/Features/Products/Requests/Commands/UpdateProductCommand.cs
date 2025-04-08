using AgriculturalSalesChain.Application.DTOs.Product;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Products.Requests.Commands
{
    public class UpdateProductCommand:IRequest<Unit>
    {
        public ProductDto ProductDto { get; set; }
    }
}
