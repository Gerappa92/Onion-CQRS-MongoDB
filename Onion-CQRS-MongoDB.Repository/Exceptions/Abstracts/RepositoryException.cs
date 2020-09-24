using System;

namespace Onion_CQRS_MongoDB.Repository.Exceptions.Abstracts
{
    public abstract class RepositoryException : Exception
    {
        public string Code { get; private set; }
        protected RepositoryException(string message, string code) : base(message)
        {
            Code = code;
        }
    }
}
