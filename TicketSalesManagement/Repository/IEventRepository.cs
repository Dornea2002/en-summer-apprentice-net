using TicketSalesManagement.Models;

namespace TicketSalesManagement.Repository
{
    public interface IEventRepository
    {
        IEnumerable<Event> GetAll();

        Task<Event> GetByID(int id);

        int Add(Event @event);
        void Update(Event @event);
        void Delete(Event @event);
    }
}
