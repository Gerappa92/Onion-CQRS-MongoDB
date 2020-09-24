using System;
using System.Collections.Generic;
using System.Text;

namespace Onion_CQRS_MongoDB.Domain.Exceptions
{
    public class DomainException : Exception
    {
        protected string Code { get; private set; }
        public DomainException(string message, string code) : base(message)
        {
            Code = code;
        }
    }
}
