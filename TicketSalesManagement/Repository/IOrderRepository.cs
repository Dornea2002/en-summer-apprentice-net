using TicketSalesManagement.Models;

namespace TicketSalesManagement.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAll();
        Task<Order> GetById(int id);
        void Delete(Order @order);
        void Update(Order @order);
    }
}
