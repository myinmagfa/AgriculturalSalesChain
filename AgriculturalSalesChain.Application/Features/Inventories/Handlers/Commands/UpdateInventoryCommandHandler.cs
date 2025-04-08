using AgriculturalSalesChain.Application.Features.Inventories.Requests.Commands;
using AgriculturalSalesChain.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Inventories.Handlers.Commands
{
    public class UpdateInventoryCommandHandler : IRequestHandler<UpdateInventoryCommand, Unit>
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IMapper _mapper;
        public UpdateInventoryCommandHandler(IInventoryRepository inventoryRepository,IMapper mapper)
        {
            _inventoryRepository = inventoryRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateInventoryCommand request, CancellationToken cancellationToken)
        {
            var inventory = await _inventoryRepository.GetAsync(request.InventoryDto.Id);
            _mapper.Map(request.InventoryDto, inventory);
            await _inventoryRepository.Update(inventory);

            return Unit.Value;
        }
    }
}
