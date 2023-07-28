using Microsoft.EntityFrameworkCore;
using TicketManagement.Models;
using TicketManagement.Repository;



namespace TicketManagement.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private TicketSalesManagementContext _dbContext;



        public OrderRepository()
        {
            _dbContext = new TicketSalesManagementContext();
        }



        public int Add(Order @order)
        {
            throw new NotImplementedException();
        }



        public void Delete(Order order)
        {
            _dbContext.Remove(order);
            _dbContext.SaveChanges();
        }



        public IEnumerable<Order> GetAll()
        {
            var @order = _dbContext.Orders.ToList();



            return order;
        }

        public async Task<Order> GetById(int id)
        {
            var @order = await _dbContext.Orders.Where(e => e.Orderid == id).FirstOrDefaultAsync();

            return order;
        }

/*        public Task<Order> GetById(int id)
        {
            throw new NotImplementedException();
        }*/

        public void Update(Order @order)
        {
            _dbContext.Entry(@order).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Update(Task<Order> orderEntity)
        {
            throw new NotImplementedException();
        }
    }
}