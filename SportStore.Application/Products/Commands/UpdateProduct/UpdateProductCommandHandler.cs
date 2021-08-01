using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SportStore.Application.Interfaces;

namespace SportStore.Application.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        public IDbContext context;
        public UpdateProductCommandHandler(IDbContext context) => (this.context) = (context);
        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var updateProduct = await context.Products.FirstOrDefaultAsync(p=>p.Id==request.Id);
            if (updateProduct == null) 
            {
                throw new Exception();
            }
            updateProduct.PhotoLink = request.PhotoLink;
            updateProduct.Price = request.Price;
            updateProduct.ProductName = request.ProductName;
            updateProduct.CategoryId = request.CategoryId;

            await context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
