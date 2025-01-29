using AgriculturalSalesChain.Application.DTOs.Product;
using AgriculturalSalesChain.Application.Features.Products.Requests.Queries;
using AgriculturalSalesChain.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Products.Handlers.Queries
{
    public class GetProductDetailRequestHandler:IRequestHandler<GetProductDetailRequest,ProductDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductDetailRequestHandler(IProductRepository productRepository,IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ProductDto> Handle(GetProductDetailRequest request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetAsync(request.Id);
            return _mapper.Map<ProductDto>(product);
        }
    }
}
