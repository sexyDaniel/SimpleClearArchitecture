using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportStore.Application.Products.Queries.GetProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IMediator mediatr;

        public ProductController(IMediator mediatr) => this.mediatr = mediatr;

        [HttpGet]
        public async Task<ActionResult<ProductVm>> Products() 
        {
            var query = new GetProductsQuery();
            var vm = await mediatr.Send(query);
            return Ok(vm);
        }
    }
}
