using Onion_CQRS_MongoDB.Services.Commands.Abstracts;

namespace Onion_CQRS_MongoDB.Services.CommandBus
{
    public interface ICommandBus
    {
        public void Send<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
