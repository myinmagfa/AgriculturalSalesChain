using AgriculturalSalesChain.Application.DTOs.Category;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Categories.Requests.Commands
{
    public class UpdateCategoryCommand:IRequest<Unit>
    {
        public CategoryDto CategoryDto { get; set; }
    }
}
