using AutoMapper;
using SportStore.Application.Common.Mapping;
using SportStore.Application.Products.Commands.CreateProduct;
using System;

namespace SportStore.WebApi.Models
{
    public class CreateProductDto:IMapWith<CreateProductCommand>
    {
        public string Name { get; set; }
        public string PhotoLink { get; set; }
        public Guid CategoryId { get; set; }
        public double Price { get; set; }

        public void Mapping(Profile profile) 
        {
            profile.CreateMap<CreateProductDto, CreateProductCommand>()
                .ForMember(pCommand => pCommand.PhotoLink, opt => opt.MapFrom(pDto => pDto.PhotoLink))
                .ForMember(pCommand => pCommand.Price, opt => opt.MapFrom(pDto => pDto.Price))
                .ForMember(pCommand => pCommand.ProductName, opt => opt.MapFrom(pDto => pDto.Name))
                .ForMember(pCommand => pCommand.CategoryId, opt => opt.MapFrom(pDto => pDto.CategoryId));
        }
    }
}
