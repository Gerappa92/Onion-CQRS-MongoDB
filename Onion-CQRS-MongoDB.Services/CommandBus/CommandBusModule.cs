using Autofac;
using Onion_CQRS_MongoDB.Services.Commands.Abstracts;
using System;

namespace Onion_CQRS_MongoDB.Services.CommandBus
{
    public class CommandBusModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.Register<Func<Type, ICommandHandler>>(c =>
            {
                var ctx = c.Resolve<IComponentContext>();

                return type =>
                {
                    var handlerType = typeof(ICommandHandler<>).MakeGenericType(type);
                    return (ICommandHandler)ctx.Resolve(handlerType);
                };
            });

            builder.RegisterType<CommandBus>()
                .AsImplementedInterfaces();
        }
    }
}
