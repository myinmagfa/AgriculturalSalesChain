using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgriculturalSalesChain.Application.DTOs.Inventory;
using AgriculturalSalesChain.Application.Features.Inventories.Requests.Queries;
using AgriculturalSalesChain.Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace AgriculturalSalesChain.Application.Features.Inventories.Handlers.Queries
{
    public class GetInventoryListRequestHandler : IRequestHandler<GetInventoryListRequest, List<InventoryDto>>
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IMapper _mapper;

        public GetInventoryListRequestHandler(IInventoryRepository inventoryRepository, IMapper mapper)
        {
            _inventoryRepository = inventoryRepository;
            _mapper = mapper;
        }

        public async Task<List<InventoryDto>> Handle(GetInventoryListRequest request, CancellationToken cancellationToken)
        {
            var inventoryList = await _inventoryRepository.GetAllAsync();
            return _mapper.Map<List<InventoryDto>>(inventoryList);
        }
    }
}
