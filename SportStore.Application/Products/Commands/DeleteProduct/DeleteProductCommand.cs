using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.Application.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand:IRequest
    {
        public Guid ProductId { get; set; }
    }
}
