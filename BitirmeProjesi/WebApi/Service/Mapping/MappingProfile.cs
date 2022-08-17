using AutoMapper;
using Base;
using Entities;

namespace Service
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<User, UserForRegisterDto>().ReverseMap();
        }

    }
}
