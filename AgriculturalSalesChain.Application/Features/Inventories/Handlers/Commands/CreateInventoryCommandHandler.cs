using AgriculturalSalesChain.Application.Features.Inventories.Requests.Commands;
using AgriculturalSalesChain.Application.Persistence.Contracts;
using AgriculturalSalesChain.Domain;
using AutoMapper;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Inventories.Handlers.Commands;

public class CreateInventoryCommandHandler : IRequestHandler<CreateInventoryCommand, int>
{
    private readonly IInventoryRepository _inventoryRepository;
    private readonly IMapper _mapper;

    public CreateInventoryCommandHandler(IInventoryRepository inventoryRepository,
        IMapper mapper)
    {
        _inventoryRepository = inventoryRepository;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateInventoryCommand request, CancellationToken cancellationToken)
    {
        var inventory = _mapper.Map<Inventory>(request.InventoryDto);
        inventory = await _inventoryRepository.Add(inventory);
        return inventory.Id;
    }
}