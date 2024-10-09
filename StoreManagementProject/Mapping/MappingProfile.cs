using AutoMapper;
using StoreManagementProject.Web.Api.Models;
using StoreManagementProject.Web.Api.Models.Dtos;

namespace StoreManagementProject.Web.Api.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductDto>();
        CreateMap<ProductDto, Product>();
    }
}
