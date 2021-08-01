using System;
using MediatR;

namespace SportStore.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommand:IRequest<Guid>
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string PhotoLink { get; set; }
        public Guid CategoryId { get; set; }
    }
}
