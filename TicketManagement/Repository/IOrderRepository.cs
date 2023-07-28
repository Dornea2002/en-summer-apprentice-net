using TicketManagement.Models;

namespace TicketManagement.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAll();

        Task<Order> GetById(int id);

        int Add(Order @order);
        void Update(Order @order);
        void Delete(Order @order);
        void Update(Task<Order> orderEntity);
    }
}
