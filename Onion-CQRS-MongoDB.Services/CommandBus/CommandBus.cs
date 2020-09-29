using Onion_CQRS_MongoDB.Services.Commands.Abstracts;
using System;

namespace Onion_CQRS_MongoDB.Services.CommandBus
{
    public class CommandBus : ICommandBus
    {
        private readonly Func<Type, ICommandHandler> _handlersFactory;

        public CommandBus(Func<Type, ICommandHandler> handlersFactory)
        {
            _handlersFactory = handlersFactory;
        }

        public void Send<TCommand>(TCommand command) where TCommand : ICommand
        {
            var handler = (ICommandHandler<TCommand>)_handlersFactory(typeof(TCommand));
            handler.HandleAsync(command);
        }
    }
}
