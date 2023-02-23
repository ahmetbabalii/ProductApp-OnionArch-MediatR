using AutoMapper;
using ProductApp.Application.Dto;
using ProductApp.Application.Features.Commands.CreateProduct;
using ProductApp.Application.Features.Queries.GetProductByOd;

namespace ProductApp.Application.Mapping
{
    // Tek bir profile olduğundan merkezi bir yere aldık
    // Eğer birden çok olsaydı ilgili Queries altına ayrı ayrı da alınabilirdi
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Domain.Entities.Product, ProductViewDto>()                
                .ReverseMap();

            CreateMap<Domain.Entities.Product, CreateProductCommand>()
                .ReverseMap();

            CreateMap<Domain.Entities.Product, GetProductByIdViewModel>()
                .ReverseMap();
        }
    }
}
