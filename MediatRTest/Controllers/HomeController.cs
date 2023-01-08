using MediatR;
using MediatRTest.DTO;
using MediatRTest.Product.Commands.Create;
using Microsoft.AspNetCore.Mvc;

namespace MediatRTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public HomeController(IMediator mediator)
        {
                _mediator = mediator;   
        }


        [HttpGet]
        public async Task<ActionResult> Test()
        {
         var f=await _mediator.Send<ProductDto>(new AddProductCommand());
           return Ok();
        }
    }
}
