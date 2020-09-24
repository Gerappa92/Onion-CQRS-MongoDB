using System;
using System.Collections.Generic;
using System.Text;

namespace Onion_CQRS_MongoDB.Domain.Exceptions.AnimalExceptions
{
    public class AnimalSpecieNullException : DomainException
    {
        public AnimalSpecieNullException() : base("Specie can't be null", "animal_specie_null_exception")
        {
        }
    }
}
