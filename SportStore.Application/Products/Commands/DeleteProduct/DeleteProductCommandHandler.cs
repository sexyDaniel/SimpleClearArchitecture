using SportStore.Application.Interfaces;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;

namespace SportStore.Application.Products.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly IDbContext context;
        public DeleteProductCommandHandler(IDbContext context) => (this.context) = (context);
        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await context.Products.FirstOrDefaultAsync(p=>p.Id==request.ProductId);
            if (product == null) 
            {
                throw new Exception();
            }
            context.Products.Remove(product);
            await context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
