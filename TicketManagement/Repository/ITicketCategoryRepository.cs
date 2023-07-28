using TicketManagement.Models;

namespace TicketManagement.Repository
{
    public interface ITicketCategoryRepository
    {
        Task<TicketCategory> GetById(int id);
    }
}
