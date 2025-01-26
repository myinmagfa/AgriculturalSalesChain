using AgriculturalSalesChain.Application.DTOs;
using AgriculturalSalesChain.Domain;
using AutoMapper;

namespace AgriculturalSalesChain.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Inventory, InventoryDto>().ReverseMap();
        CreateMap<Order, OrderDto>().ReverseMap();
        CreateMap<Product, ProductDto>().ReverseMap();
    }
}