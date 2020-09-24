using System;
using System.Collections.Generic;
using System.Text;

namespace Onion_CQRS_MongoDB.Domain.Exceptions.AnimalExceptions
{
    public class AnimalAgeException : DomainException
    {
        public AnimalAgeException(string message) : base(message, "animal_age_exception")
        {
        }
    }
}
