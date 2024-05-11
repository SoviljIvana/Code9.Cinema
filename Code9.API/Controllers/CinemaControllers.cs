using Code9.Domain.Models;
using Code9.Domain.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace Code9.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CinemaControllers : ControllerBase
    {
        private readonly IMediator _mediator;
        public CinemaControllers(IMediator mediator)
        {
            _mediator = mediator;
        }
     


        [HttpGet]
        public async Task<ActionResult<List<Cinema>>> GetAllCinema()
        {
            var query = new GetAllCinemaQuery();
            var cinema = await _mediator.Send(query);
            return Ok(cinema);
        }
        
        
       
    }
}
