using AutoMapper;
using EcomercerWebsite_Fruit.DataTransferObject;
using EcomercerWebsite_Fruit.Models;

namespace EcomercerWebsite_Fruit.Services
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<dtoCustomer, Customer>().ReverseMap();
            CreateMap<dtoProduct, Product>().ReverseMap();

        }
    }
}
