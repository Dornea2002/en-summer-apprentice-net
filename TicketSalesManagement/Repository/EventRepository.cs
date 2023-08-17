using Microsoft.EntityFrameworkCore;
using TicketSalesManagement.Models;

namespace TicketSalesManagement.Repository
{
    public class EventRepository : IEventRepository
    {
        private readonly TicketSalesManagementContext _dbContext;
        public EventRepository()
        {

            _dbContext = new TicketSalesManagementContext();
        }
        public int Add(Event @event)
        {
            throw new NotImplementedException();
        }

        public void Delete(Event @event)
        {
            _dbContext.Remove(@event);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Event> GetAll()
        {
            var events = _dbContext.Events.Include(e => e.Venue).Include(e => e.EventType).Include(e => e.TicketCategories);

            return events;
        }

        public async Task<Event> GetByID(int id)
        {
            var @event = await _dbContext.Events.Where(e => e.Eventid == id).FirstOrDefaultAsync();
            return @event;
        }

        public void Update(Event @event)
        {
            _dbContext.Entry(@event).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
