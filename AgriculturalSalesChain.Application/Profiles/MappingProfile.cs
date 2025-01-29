using AgriculturalSalesChain.Application.DTOs.Category;
using AgriculturalSalesChain.Application.DTOs.Inventory;
using AgriculturalSalesChain.Application.DTOs.Order;
using AgriculturalSalesChain.Application.DTOs.Product;
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