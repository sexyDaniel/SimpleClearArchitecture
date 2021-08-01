using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.Application.Products.Queries.GetProducts
{
    public class ProductVm
    {
        public IList<ProductDto> Products { get; set; }
    }
}
