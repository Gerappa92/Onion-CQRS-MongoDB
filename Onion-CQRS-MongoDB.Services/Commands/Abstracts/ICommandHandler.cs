using System.Threading.Tasks;

namespace Onion_CQRS_MongoDB.Services.Commands.Abstracts
{
    public interface ICommandHandler
    {

    }

    public interface ICommandHandler<T> : ICommandHandler where T : ICommand
    {
        public Task HandleAsync(T command);
    }
}
