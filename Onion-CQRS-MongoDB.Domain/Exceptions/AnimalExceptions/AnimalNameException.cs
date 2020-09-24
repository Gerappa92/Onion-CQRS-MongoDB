using System;
using System.Collections.Generic;
using System.Text;

namespace Onion_CQRS_MongoDB.Domain.Exceptions.AnimalExceptions
{
    public class AnimalNameException : DomainException
    {
        public AnimalNameException(string message) : base(message, "animal_name_exception")
        {
        }
    }
}
