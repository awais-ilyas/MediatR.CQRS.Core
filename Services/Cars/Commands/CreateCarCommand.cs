using MediatR;
using Services.Models;
using Services.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Cars.Commands
{
   public class CreateCarCommand : IRequestWrapper<Car>
    {

    }

    public class CreateCarCommandHandler : IHandlerWrapper<CreateCarCommand, Car>
    {
        public Task<Responce<Car>> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(true ? Response.Ok(new Car { Name = "Mazda", Model = "RX 8" }, "Car created") : Response.Fail<Car>("Already Exists"));
        }
    }
}
