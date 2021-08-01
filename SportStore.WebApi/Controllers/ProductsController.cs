using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportStore.Application.Products.Commands.CreateProduct;
using SportStore.Application.Products.Queries.GetProducts;
using SportStore.WebApi.Models;
using System.Threading.Tasks;

namespace SportStore.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IMediator mediator;
        private IMapper mapper;

        public ProductsController(IMediator mediator,IMapper mapper) => (this.mediator,this.mapper) =( mediator,mapper);

        [HttpGet("all")]
        public async Task<ActionResult<ProductVm>> GetProducts() 
        {
            var query = new GetProductsQuery();
            var vm = await mediator.Send(query);
            return Ok(vm);
        }

        [HttpPost("add")]
        public async Task<ActionResult<ProductVm>> Add([FromBody] CreateProductDto createProductDto)
        {
            var query = mapper.Map<CreateProductCommand>(createProductDto);
            var vm = await mediator.Send(query);
            return Ok(vm);
        }
    }
}
