using AgriculturalSalesChain.Application.DTOs.Product;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Products.Requests.Queries
{
    public class GetProductDetailRequest : IRequest<ProductDto>
    {
        public int Id { get; set; }
    }
}
