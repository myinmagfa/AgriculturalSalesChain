using AgriculturalSalesChain.Application.DTOs;
using AgriculturalSalesChain.Application.Features.Categories.Requests.Queries;
using AgriculturalSalesChain.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Categories.Handlers.Queries
{
    public class GetCategoryListRequestHandler:
        IRequestHandler<GetCategoryListRequest,List<CategoryDto>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoryListRequestHandler(ICategoryRepository categoryRepository,IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        
        public async Task<List<CategoryDto>> Handle(GetCategoryListRequest request, CancellationToken cancellationToken)
        {
            var categoryList = await _categoryRepository.GetAllAsync();
            return _mapper.Map<List<CategoryDto>>(categoryList);
        }
    }
}
