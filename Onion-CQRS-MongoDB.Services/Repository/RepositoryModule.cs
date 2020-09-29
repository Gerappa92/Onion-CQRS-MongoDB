using Autofac;
using Onion_CQRS_MongoDB.Repository.Repositories.Abstracts;
using Onion_CQRS_MongoDB.Repository.Repositories.Entities;
using Onion_CQRS_MongoDB.Repository.Repositories.Interfaces;
using Onion_CQRS_MongoDB.Repository.Repositories.ValueObjects;

namespace Onion_CQRS_MongoDB.Services.Repository
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterGeneric(typeof(MongoEntityRepository<>)).As(typeof(IEntityRepository<>));
            builder.RegisterGeneric(typeof(MongoValueObjectRepository<>)).As(typeof(IValueObjectRepository<>));
            builder.RegisterType(typeof(AnimalRepository)).As(typeof(IAnimalRepository));
            builder.RegisterType(typeof(SpeciesRepository)).As(typeof(ISpeciesRepository));
        }
    }
}
