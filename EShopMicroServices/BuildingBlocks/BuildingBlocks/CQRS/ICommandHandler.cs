using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.CQRS
{
    public interface ICommandHandler<in TCommand>
    : ICommandHandler<TCommand, Unit>
    where TCommand : ICommand<Unit>
    {
    }

    public interface ICommandHandler<in TCommand, TReesponse> : IRequestHandler<TCommand, TReesponse>
        where TCommand : ICommand<TReesponse>
        where TReesponse : notnull
    {
    }
}
