using AgriculturalSalesChain.Application.DTOs.Product;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Products.Requests.Queries
{
    public class GetProductListRequest:IRequest<List<ProductDto>>
    {
    }
}
