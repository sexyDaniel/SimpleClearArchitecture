using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SportStore.Application.Interfaces;
using SportStore.Domain;

namespace SportStore.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
    {
        private readonly IDbContext context;
        public CreateProductCommandHandler(IDbContext context) => this.context = context;
        public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product()
            {
                ProductName = request.ProductName,
                Price = request.Price,
                PhotoLink = request.PhotoLink,
                CategoryId = request.CategoryId
            };
            await context.Products.AddAsync(product);
            await context.SaveChangesAsync(cancellationToken);
            return Guid.NewGuid();
        }
    }
}
