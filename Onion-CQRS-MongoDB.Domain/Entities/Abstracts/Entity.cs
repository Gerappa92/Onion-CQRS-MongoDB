using System;

namespace Onion_CQRS_MongoDB.Domain.Entities
{
    public abstract class Entity
    {
        protected Guid Id { get; set; } = Guid.NewGuid();
        protected DateTime CreateDate { get; set; } = DateTime.Now;
        protected DateTime ModificationDate { get; set; } = DateTime.Now;
    }
}
