using AgriculturalSalesChain.Domain;
using AgriculturalSalesChain.Application.Features.Products.Requests.Commands;
using AgriculturalSalesChain.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Products.Handlers.Commands
{
    public class CreateProductCommandHandler:IRequestHandler<CreateProductCommand,int>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IProductRepository productRepository,IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request.ProductDto);
            product = await _productRepository.Add(product);
            return product.Id;
        }
    }
}
