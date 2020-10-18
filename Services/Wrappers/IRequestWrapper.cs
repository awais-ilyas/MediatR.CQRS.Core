using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Wrappers
{
    public interface IRequestWrapper<T> : IRequest<Responce<T>>
    {
    }

    public interface IHandlerWrapper<TIn, TOut> : IRequestHandler<TIn, Responce<TOut>>
        where TIn : IRequestWrapper<TOut>
    {

    }
}
