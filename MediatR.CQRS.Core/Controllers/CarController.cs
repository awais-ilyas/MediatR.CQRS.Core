using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services;
using Services.Cars.Commands;
using Services.Cars.Queries;
using Services.Models;

namespace MediatR.CQRS.Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CarController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("")]
        public Task<IEnumerable<Car>> Get()
        {
            return _mediator.Send(new GetAllCarsQuery());
        }


        [HttpPost("post")]
        public Task<Responce<Car>> Post([FromBody] CreateCarCommand command)
        {
            return _mediator.Send(command);
        }

    }
}
