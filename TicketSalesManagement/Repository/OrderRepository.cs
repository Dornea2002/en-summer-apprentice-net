using Microsoft.EntityFrameworkCore;
using System;
using TicketSalesManagement.Models;

namespace TicketSalesManagement.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly TicketSalesManagementContext _dbContext;

        public OrderRepository()
        {
            _dbContext = new TicketSalesManagementContext();
        }
        public IEnumerable<Order> GetAll()
        {
            var orders = _dbContext.Orders;

            return orders;
        }

        public async Task<Order> GetById(int id)
        {
            var @order = await _dbContext.Orders.Where(o => o.Orderid == id).FirstOrDefaultAsync();
/*
            if (@order == null)
                throw new Exceptions.EntityNotFoundException(id, nameof(Order));*/

            return @order;
        }

        public void Delete(Order @order)
        {
            _dbContext.Remove(@order);
            _dbContext.SaveChanges();
        }

        public void Update(Order @order)
        {
            _dbContext.Entry(@order).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Insert(Order order)
        {
            _dbContext.Entry(order).State = EntityState.Added;
            _dbContext.SaveChanges();
        }
    }
}
