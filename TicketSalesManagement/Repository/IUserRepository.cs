using TicketSalesManagement.Models;

namespace TicketSalesManagement.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        Task<User> GetById(int id);
        int Add(User @customer);
        void Update(User @customer);
        void Delete(User @customer);
    }
}
