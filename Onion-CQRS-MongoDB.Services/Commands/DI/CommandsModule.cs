using Autofac;
using Onion_CQRS_MongoDB.Services.Commands.Abstracts;

namespace Onion_CQRS_MongoDB.Services.Commands.DI
{
    public class CommandsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(x => x.IsAssignableTo<ICommandHandler>())
                .AsImplementedInterfaces();
        }
    }
}
