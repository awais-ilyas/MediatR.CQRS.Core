using MediatR;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Cars.Queries
{
    public class GetAllCarsQuery : IRequest<IEnumerable<Car>>
    {
    }

    public class GetAllCarsQueryHandler : IRequestHandler<GetAllCarsQuery, IEnumerable<Car>>
    {
        //do dependency injection here if need
        public GetAllCarsQueryHandler()
        {

        }

        public async Task<IEnumerable<Car>> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
        {
            return new[] {
                new Car { Name = "Ford", Model = "Explorer"  },
                new Car { Name = "BMW", Model = "M5"  }
            };
        }
    }
}
