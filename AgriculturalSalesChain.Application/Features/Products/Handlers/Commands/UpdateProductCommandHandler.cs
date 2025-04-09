using AgriculturalSalesChain.Application.Features.Products.Requests.Commands;
using AgriculturalSalesChain.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Products.Handlers.Commands
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Unit>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public UpdateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product=await _productRepository.GetAsync(request.ProductDto.Id);
            _mapper.Map(request.ProductDto, product);
            await _productRepository.Update(product);

            return Unit.Value;
        }
    }
}
