using Onion_CQRS_MongoDB.Domain.Exceptions.AnimalExceptions;
using Onion_CQRS_MongoDB.Domain.Types;
using Onion_CQRS_MongoDB.Domain.ValueObjects;

namespace Onion_CQRS_MongoDB.Domain.Entities
{
    public class Animal : Entity
    {
        public Animal(string name, int age, Gender gender, Species
            species)
        {
            SetName(name);
            SetAge(age);
            Gender = gender;
            SetSpecies(species);
        }

        private void SetName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new AnimalNameException("The name cannot be empty");
            }
            if(name.Length < 5)
            {
                throw new AnimalNameException("The name must be at least 5 characters long");
            }
            Name = name;
        }
        private void SetAge(int age)
        {
            if(age < 0)
            {
                throw new AnimalAgeException("Age must be positive");
            }
            Age = age;
        }
        private void SetSpecies(Species
            species)
        {
            if(species == null)
            {
                throw new AnimalSpecieNullException();
            }
            Species = species;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public Gender Gender { get; private set; }
        public Species Species { get; private set; }

    }
}
