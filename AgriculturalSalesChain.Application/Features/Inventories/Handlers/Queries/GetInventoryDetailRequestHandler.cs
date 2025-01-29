using AgriculturalSalesChain.Application.DTOs.Inventory;
using AgriculturalSalesChain.Application.Features.Inventories.Requests.Queries;
using AgriculturalSalesChain.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Inventories.Handlers.Queries
{
    public class GetInventoryDetailRequestHandler:IRequestHandler<GetInventoryDetailRequest,InventoryDto>
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IMapper _mapper;

        public GetInventoryDetailRequestHandler(IInventoryRepository inventoryRepository,IMapper mapper)
        {
            _inventoryRepository = inventoryRepository;
            _mapper = mapper;
        }

        public async Task<InventoryDto> Handle(GetInventoryDetailRequest request, CancellationToken cancellationToken)
        {
            var order = await _inventoryRepository.GetAsync(request.Id);
            return _mapper.Map<InventoryDto>(order);
        }
    }
}
