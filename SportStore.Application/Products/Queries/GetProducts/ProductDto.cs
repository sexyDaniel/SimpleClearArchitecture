using SportStore.Application.Common.Mapping;
using SportStore.Domain;
using AutoMapper;

namespace SportStore.Application.Products.Queries.GetProducts
{
    public class ProductDto:IMapWith<Product>
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string PhotoLink { get; set; }

        public void Mapping(Profile profile) 
        {
            profile.CreateMap<Product, ProductDto>()
                .ForMember(pDto => pDto.PhotoLink, opt => opt.MapFrom(note => note.PhotoLink))
                .ForMember(pDto => pDto.Price, opt => opt.MapFrom(note => note.Price))
                .ForMember(pDto => pDto.ProductName, opt => opt.MapFrom(note => note.ProductName));
        }
    }
}
