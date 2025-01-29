using AgriculturalSalesChain.Application.Features.Categories.Requests.Commands;
using AgriculturalSalesChain.Application.Persistence.Contracts;
using AgriculturalSalesChain.Domain;
using AutoMapper;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Categories.Handlers.Commands;

public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, int>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CreateCategoryCommandHandler(ICategoryRepository categoryRepository,
        IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = _mapper.Map<Category>(request.CategoryDto);
        category = await _categoryRepository.Add(category);
        return category.Id;
    }
}