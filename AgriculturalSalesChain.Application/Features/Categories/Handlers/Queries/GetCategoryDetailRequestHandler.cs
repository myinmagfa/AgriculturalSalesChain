using AgriculturalSalesChain.Application.DTOs.Category;
using AgriculturalSalesChain.Application.Features.Categories.Requests.Queries;
using AgriculturalSalesChain.Application.Persistence.Contracts;
using AutoMapper;
using AutoMapper.Configuration;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Categories.Handlers.Queries;

public class GetCategoryDetailRequestHandler : IRequestHandler<
    GetCategoryDetailRequest, CategoryDto
>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public GetCategoryDetailRequestHandler(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }
    public async Task<CategoryDto> Handle(GetCategoryDetailRequest request, CancellationToken cancellationToken)
    {
        var category = await _categoryRepository.GetAsync(request.Id);
        return _mapper.Map<CategoryDto>(category);
    }
}