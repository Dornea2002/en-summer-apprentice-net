using System.Globalization;

namespace TicketSalesManagement.Exceptions
{
    public class EntityNotFound : Exception
    {
        public EntityNotFound() { }
        public EntityNotFound(string message) : base(message) { }
        public EntityNotFound(string message, Exception innerException) : base(message, innerException) { }
        public EntityNotFound(int entityId, string entityName) : base( FormattableString.Invariant($"'{entityName}' with id '{entityId}' was not found!")) { }
    }
}
