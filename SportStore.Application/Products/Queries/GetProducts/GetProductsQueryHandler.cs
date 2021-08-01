using AutoMapper;
using MediatR;
using SportStore.Application.Interfaces;
using AutoMapper.QueryableExtensions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SportStore.Application.Products.Queries.GetProducts
{
    class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, ProductVm>
    {
        private IDbContext context;
        private readonly IMapper mapper;
        public GetProductsQueryHandler(IDbContext context, IMapper mapper) => (this.mapper,this.context) = (mapper,context);
        public async Task<ProductVm> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await context.Products
                .ProjectTo<ProductDto>(mapper.ConfigurationProvider)
                .ToListAsync();
            return new ProductVm { Products = products };
        }
    }
}
