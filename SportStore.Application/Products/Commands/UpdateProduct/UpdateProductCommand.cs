using System;
using MediatR;

namespace SportStore.Application.Products.Commands.UpdateProduct
{
    public class UpdateProductCommand:IRequest
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string PhotoLink { get; set; }
    }
}
