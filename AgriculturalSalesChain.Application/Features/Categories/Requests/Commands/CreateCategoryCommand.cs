using AgriculturalSalesChain.Application.DTOs.Category;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Categories.Requests.Commands;

public class CreateCategoryCommand : IRequest<int>
{
    public CategoryDto CategoryDto { get; set; }
}