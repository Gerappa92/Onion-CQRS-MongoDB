namespace Onion_CQRS_MongoDB.Domain.Exceptions.SpeciesException
{
    public class SpeciesNameException : DomainException
    {
        public SpeciesNameException(string message) : base(message, "species_name_exception")
        {
        }
    }
}
