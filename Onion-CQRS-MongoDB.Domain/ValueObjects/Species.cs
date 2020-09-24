using Onion_CQRS_MongoDB.Domain.Exceptions.SpeciesException;
using Onion_CQRS_MongoDB.Domain.Types;
using System.Collections.Generic;

namespace Onion_CQRS_MongoDB.Domain.ValueObjects
{
    public class Species : ValueObject
    {
        public string Name { get; private set; }
        public AnimalClass AnimalClass { get; private set; }
        public ConsumeType ConsumeType { get; private set; }

        public Species(string name, AnimalClass animalClass, ConsumeType consumeType)
        {
            SetName(name);
            AnimalClass = animalClass;
            ConsumeType = consumeType;
        }

        private void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new SpeciesNameException("The name cannot be empty");
            }
            if(name.Length < 3)
            {
                throw new SpeciesNameException("The name must be at least 3 characters long");
            }
            Name = name;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return AnimalClass;
            yield return ConsumeType;
        }
    }
}
